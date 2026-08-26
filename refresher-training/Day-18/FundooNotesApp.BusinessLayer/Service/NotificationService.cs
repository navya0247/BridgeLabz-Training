using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.BusinessLayer.Helper;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.BusinessLayer.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _repository;
        private readonly IUserRepository _userRepository;
        private readonly RabbitMqPublisher _publisher;

        // repositories and publisher injected here
        public NotificationService(INotificationRepository repository, IUserRepository userRepository, RabbitMqPublisher publisher)
        {
            _repository = repository;
            _userRepository = userRepository;
            _publisher = publisher;
        }

        private NotificationResponseDto MapToDto(NotificationEntity n)
        {
            return new NotificationResponseDto
            {
                NotificationId = n.NotificationId,
                NoteId = n.NoteId,
                Message = n.Message,
                IsRead = n.IsRead,
                CreatedAt = n.CreatedAt
            };
        }

        public List<NotificationResponseDto> GetAllNotifications(int userId)
        {
            var notifications = _repository.GetAllNotifications(userId);
            return notifications.Select(MapToDto).ToList();
        }

        public NotificationResponseDto MarkAsRead(long notificationId, int userId)
        {
            var notification = _repository.MarkAsRead(notificationId, userId);
            if (notification == null)
                throw new NoteNotFoundException("Notification not found or you do not have access");

            return MapToDto(notification);
        }

        public void ProcessDueReminders()
        {
            var dueNotes = _repository.GetDueReminders();

            foreach (var note in dueNotes)
            {
                // save in-app notification like before
                var notification = new NotificationEntity
                {
                    NoteId = note.NoteId,
                    UserId = note.UserId,
                    Message = $"Reminder: {note.Title}",
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow
                };
                _repository.AddNotification(notification);
                _repository.MarkNoteAsNotified(note.NoteId);

                                // find user email and publish email job to rabbitmq queue
                var user = _userRepository.GetUserById(note.UserId);
                if (user != null)
                {
                    _publisher.PublishReminderEmail(new ReminderEmailMessage
                    {
                        ToEmail = user.Email,
                        NoteTitle = note.Title
                    }).GetAwaiter().GetResult();
                }
            }
        }
    }
}
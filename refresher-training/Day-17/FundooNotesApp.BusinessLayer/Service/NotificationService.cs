using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.BusinessLayer.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _repository;

        // repository injected here
        public NotificationService(INotificationRepository repository)
        {
            _repository = repository;
        }

        // maps entity to response dto
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
            // find notes whose reminder time has passed
            var dueNotes = _repository.GetDueReminders();

            foreach (var note in dueNotes)
            {
                // create a notification for each due reminder
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
            }
        }
    }
}
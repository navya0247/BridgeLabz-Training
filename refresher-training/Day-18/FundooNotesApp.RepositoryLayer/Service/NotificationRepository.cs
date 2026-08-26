using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.RepositoryLayer.Service
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly AppDbContext _context;

        // db context injected here
        public NotificationRepository(AppDbContext context)
        {
            _context = context;
        }

        public NotificationEntity AddNotification(NotificationEntity notification)
        {
            _context.Notifications.Add(notification);
            _context.SaveChanges();
            return notification;
        }

        public List<NotificationEntity> GetAllNotifications(int userId)
        {
            return _context.Notifications
                .Where(n => n.UserId == userId)
                .OrderByDescending(n => n.CreatedAt)
                .ToList();
        }

        public NotificationEntity? MarkAsRead(long notificationId, int userId)
        {
            var notification = _context.Notifications
                .FirstOrDefault(n => n.NotificationId == notificationId && n.UserId == userId);
            if (notification == null) return null;

            notification.IsRead = true;
            _context.SaveChanges();
            return notification;
        }

        public List<NotesEntity> GetDueReminders()
        {
           
            return _context.Notes
                .Where(n => n.Reminder != null && n.Reminder <= DateTime.UtcNow && !n.Notified)
                .ToList();
        }

        public void MarkNoteAsNotified(long noteId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.NoteId == noteId);
            if (note == null) return;

            note.Notified = true;
            _context.SaveChanges();
        }
    }
}
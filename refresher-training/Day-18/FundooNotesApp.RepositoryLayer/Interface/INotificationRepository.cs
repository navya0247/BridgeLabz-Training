using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interface
{
    public interface INotificationRepository
    {
        NotificationEntity AddNotification(NotificationEntity notification);
        List<NotificationEntity> GetAllNotifications(int userId);
        NotificationEntity? MarkAsRead(long notificationId, int userId);
        List<NotesEntity> GetDueReminders();
        void MarkNoteAsNotified(long noteId);
    }
}
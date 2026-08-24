using FundooNotesApp.ModelLayer.Dtos.Response;

namespace FundooNotesApp.BusinessLayer.Interface
{
    public interface INotificationService
    {
        List<NotificationResponseDto> GetAllNotifications(int userId);
        NotificationResponseDto MarkAsRead(long notificationId, int userId);

        // checks all due reminders and creates notifications
        void ProcessDueReminders();
    }
}
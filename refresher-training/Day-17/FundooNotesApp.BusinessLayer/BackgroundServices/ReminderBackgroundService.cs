using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FundooNotesApp.BusinessLayer.Interface;

namespace FundooNotesApp.BusinessLayer.BackgroundServices
{
    public class ReminderBackgroundService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        // service provider injected to create scoped services manually
        public ReminderBackgroundService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // runs in a loop every minute, checking for due reminders
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
                    notificationService.ProcessDueReminders();
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
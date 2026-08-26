using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.BusinessLayer.Helper;

namespace FundooNotesApp.BusinessLayer.BackgroundServices
{
    public class EmailConsumerBackgroundService : BackgroundService
    {
        private readonly string _hostName;
        private readonly string _queueName;
        private readonly EmailSender _emailSender;

        // dependencies injected here
        public EmailConsumerBackgroundService(string hostName, string queueName, EmailSender emailSender)
        {
            _hostName = hostName;
            _queueName = queueName;
            _emailSender = emailSender;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory { HostName = _hostName };

            var connection = await factory.CreateConnectionAsync(stoppingToken);
            var channel = await connection.CreateChannelAsync(cancellationToken: stoppingToken);

            await channel.QueueDeclareAsync(queue: _queueName, durable: false, exclusive: false, autoDelete: false, cancellationToken: stoppingToken);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.ReceivedAsync += async (model, ea) =>
            {
                // triggered whenever a new message arrives in the queue
                var body = ea.Body.ToArray();
                string json = Encoding.UTF8.GetString(body);
                var emailMessage = JsonSerializer.Deserialize<ReminderEmailMessage>(json);

                if (emailMessage != null)
                    _emailSender.SendReminderEmail(emailMessage.ToEmail, emailMessage.NoteTitle);

                await Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(queue: _queueName, autoAck: true, consumer: consumer, cancellationToken: stoppingToken);

            // keep the service alive until cancellation
            await Task.Delay(Timeout.Infinite, stoppingToken);
        }
    }
}
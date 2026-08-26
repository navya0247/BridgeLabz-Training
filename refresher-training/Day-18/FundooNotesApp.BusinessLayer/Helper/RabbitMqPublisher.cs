using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.BusinessLayer.Helper
{
    public class RabbitMqPublisher
    {
        private readonly string _hostName;
        private readonly string _queueName;

        // rabbitmq connection settings injected here
        public RabbitMqPublisher(string hostName, string queueName)
        {
            _hostName = hostName;
            _queueName = queueName;
        }

        // publishes a reminder email message to the queue
        public async Task PublishReminderEmail(ReminderEmailMessage emailMessage)
        {
            var factory = new ConnectionFactory { HostName = _hostName };

            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: _queueName, durable: false, exclusive: false, autoDelete: false);

            string json = JsonSerializer.Serialize(emailMessage);
            byte[] body = Encoding.UTF8.GetBytes(json);

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: _queueName, body: body);
        }
    }
}
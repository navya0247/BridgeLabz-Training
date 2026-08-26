using MailKit.Net.Smtp;
using MimeKit;

namespace FundooNotesApp.BusinessLayer.Helper
{
    public class EmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly string _senderEmail;
        private readonly string _senderPassword;

        // smtp settings injected here
        public EmailSender(string host, int port, string senderEmail, string senderPassword)
        {
            _host = host;
            _port = port;
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
        }

        // sends a simple reminder email
        public void SendReminderEmail(string toEmail, string noteTitle)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Fundoo Notes", _senderEmail));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = "Reminder: " + noteTitle;
            message.Body = new TextPart("plain") { Text = $"This is your reminder for the note: {noteTitle}" };

            using var client = new SmtpClient();
            client.Connect(_host, _port, false);
            client.Authenticate(_senderEmail, _senderPassword);
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
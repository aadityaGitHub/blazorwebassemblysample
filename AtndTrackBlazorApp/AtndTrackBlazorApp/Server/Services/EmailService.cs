using AtndTrackBlazorApp.Shared;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpServerSetting _appSettings;
        private readonly SmtpClient smtp = new SmtpClient();

        public EmailService(IOptionsSnapshot<SmtpServerSetting> appSettings)
        {
            _appSettings = appSettings.Value;
            smtp.Connect(_appSettings.Server, _appSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_appSettings.UserName, _appSettings.Password);

        }

        public void Send(string from, string to, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            //using var smtp = new SmtpClient();
            //smtp.Authenticate(_appSettings.UserName, _appSettings.Password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }

}

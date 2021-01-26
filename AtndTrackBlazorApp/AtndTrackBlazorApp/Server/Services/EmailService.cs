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

        }

        public void Send(string to, string subject, string html)
        {
            // create message

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_appSettings.SenderEmail));
            var validToAddress = to.Split(";").Select(o =>
            {
                if (MailboxAddress.TryParse(o, out var address))
                    return address;
                return null;
            });
            email.To.AddRange(validToAddress.Where(o=>o!=null));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            smtp.Connect(_appSettings.Server, _appSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_appSettings.UserName, _appSettings.Password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }

}

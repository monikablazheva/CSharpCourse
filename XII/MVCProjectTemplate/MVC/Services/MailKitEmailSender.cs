﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services
{
    public class MailKitEmailSender : IEmailSender
    {
        public MailKitEmailSenderOptions Options { get; set; }

        public MailKitEmailSender(IOptions<MailKitEmailSenderOptions> options)
        {
            this.Options = options.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task<bool> Execute(string to, string subject, string message)
        {
            try
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(Options.SenderEmail);
                if (!string.IsNullOrEmpty(Options.SenderName))
                    email.Sender.Name = Options.SenderName;
                email.From.Add(email.Sender);
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                email.Body = new TextPart(TextFormat.Html) { Text = message };

                using (var smtp = new SmtpClient())
                {
                    await smtp.ConnectAsync(Options.HostAddress, Options.HostPort, Options.HostSecureSocketOptions);
                    await smtp.AuthenticateAsync(Options.HostUsername, Options.HostPassword);
                    await smtp.SendAsync(email);
                    await smtp.DisconnectAsync(true);
                    return await Task.FromResult(true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

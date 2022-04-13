
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETCore.MailKit.Infrastructure.Internal;
using NETCore.MailKit.Core;
using MimeKit;
using System.IO;

namespace FinalProjectNurlan.Helpers
{
    public class EmailService : IEmailService

    {
        public void Send(string mailTo, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public void Send(string mailTo, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string mailTo, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string mailTo, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            throw new NotImplementedException();
        }


        public async Task SendEmailAsync(List<string> email, string subject, string message)

        {

            var emailMessage = new MimeMessage();




            emailMessage.From.Add(new MailboxAddress("Milla", "satilirbuz4@gmail.com"));

            foreach (var item in email)

            {

                emailMessage.To.Add(new MailboxAddress("", item));

            }

            emailMessage.Subject = subject;

            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)

            {

                Text = message

            };

            //emailMessage.Body.ht

            //using (StreamReader reader = new StreamReader("wwwroot/assets/template/VerifyEmail.html"))
            //{
            //    emailMessage.Body.te = reader.ReadToEnd();
            //}



            using (var client = new SmtpClient())

            {

                await client.ConnectAsync("smtp.gmail.com", 465, true);

                await client.AuthenticateAsync("satilirbuz4@gmail.com", "Finalproject123");

                await client.SendAsync(emailMessage);




                await client.DisconnectAsync(true);

            }

        }

    }
}

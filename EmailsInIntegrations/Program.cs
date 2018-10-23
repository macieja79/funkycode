﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MimeKit;

namespace EmailsInIntegrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var smtpClient = new SmtpClient();

            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("maciej@funkycode.pl");
            mailMessage.To.Add("recipient@funkycode.pl");
            mailMessage.Subject = "Our subject";
            mailMessage.Body = "Our body";

            smtpClient.Send(mailMessage);

      
            var lastSavedFilePath = new DirectoryInfo(@"C:\Mailbox").GetFiles().OrderByDescending(f => f.LastWriteTime).FirstOrDefault()?.FullName;
            var mimeMessage = MimeMessage.Load(lastSavedFilePath);

            var mailto = mimeMessage.To;
            var mailfrom = mimeMessage.From;
            var mailcc = mimeMessage.Cc;
            var mailsubject = mimeMessage.Subject;
            var maildate = mimeMessage.Date;
            var mailplainBody = mimeMessage.TextBody;
            var mailhtmlBody = mimeMessage.HtmlBody;

        }

      
        
    }
}

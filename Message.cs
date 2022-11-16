using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Net.Smtp;
using MimeKit;

namespace EmailService
{
    public class Message
    {
        public MailboxAddress To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Message(string to, string name, string subject, string content)
        {
            To = new MailboxAddress(name, to);
            Subject = subject;
            Content = content;
        }
    }
}


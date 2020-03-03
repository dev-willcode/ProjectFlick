using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    public class EmailSender: IEmailSender
    {
        private SmtpClient _smtpClient { get; set; }
        private string _emailFrom { get; set; }

        public EmailSender(SmtpClient smtpClient, string emailFrom)
        {
            _smtpClient = smtpClient;
            _emailFrom = emailFrom;
        }

        public Task SendEmailAsync(string emailTo, string subject, string message)
        {
            var correo = new MailMessage(from: _emailFrom, to: emailTo, subject: subject, body: message);
            correo.IsBodyHtml = true;
            return _smtpClient.SendMailAsync(correo);
        }
        public Task EnviarCorreoConArchivo(string emailTo, string subject, string message, string ruta)
        {
            Attachment data = new Attachment(ruta, MediaTypeNames.Application.Octet);
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(ruta);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(ruta);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(ruta);

            var correo = new MailMessage(from: _emailFrom, to: emailTo, subject: subject, body: message);
            correo.IsBodyHtml = true;
            correo.Attachments.Add(data);
            return _smtpClient.SendMailAsync(correo);
        }
    }
}

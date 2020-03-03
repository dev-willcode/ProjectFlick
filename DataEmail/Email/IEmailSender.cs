using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string emailTo, string subject, string message);
    }
}

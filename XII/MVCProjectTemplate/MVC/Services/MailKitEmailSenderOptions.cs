using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services
{
    // Options pattern:
    // https://learn.microsoft.com/en-US/aspnet/core/fundamentals/configuration/options?WT.mc_id=DT-MVP-5003202&view=aspnetcore-5.0

    public class MailKitEmailSenderOptions
    {
        public MailKitEmailSenderOptions()
        {
            HostSecureSocketOptions = SecureSocketOptions.Auto;
        }

        public SecureSocketOptions HostSecureSocketOptions { get; set; }

        public string HostAddress { get; set; }

        public int HostPort { get; set; }

        public string HostUsername { get; set; }

        public string HostPassword { get; set; }

        public string SenderEmail { get; set; }

        public string SenderName { get; set; }
    }
}

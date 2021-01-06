using System;
using System.Collections.Generic;
using System.Text;

namespace AtndTrackBlazorApp.Shared
{
    public class AppSetting
    {
        public SmtpServerSetting SmtpServerSetting { get; set; }
    }
    public class SmtpServerSetting
    {

            public string Server { get; set; }
            public int Port { get; set; }
            public string SenderName { get; set; }
            public string SenderEmail { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }

    }
}

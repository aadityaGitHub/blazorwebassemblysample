using System;
using System.Collections.Generic;
using System.Text;

namespace AtndTrackBlazorApp.Shared.Models
{
    public class UserNotificationModel
    {
        public int EmployeeId { get; set; }
        public string Message { get; set; }
        public string RawData { get; set; }
        public int CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AtndTrackBlazorApp.Shared.Models
{
    public class LeaveRequestModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public string EamilAlertTo { get; set; }
        public string Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset? DateFrom { get; set; }
        public DateTimeOffset? DateTo { get; set; }
        public string Reason { get; set; }
        public string EmployeeName { get; set; }
        public string Response { get; set; }


    }
}

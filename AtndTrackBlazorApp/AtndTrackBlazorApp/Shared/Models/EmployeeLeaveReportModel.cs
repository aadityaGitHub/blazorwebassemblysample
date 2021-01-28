using System;
using System.Collections.Generic;
using System.Text;

namespace AtndTrackBlazorApp.Shared.Models
{
    public class EmployeeLeaveReportModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int SLLeaveCount { get; set; }
        public int CLLeaveCount { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
    }
}

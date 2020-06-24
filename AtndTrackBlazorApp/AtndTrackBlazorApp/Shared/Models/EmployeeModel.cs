using System;
using System.Linq;
using System.Collections.Generic;

namespace AtndTrackBlazorApp.Shared.Models
{
   public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }

        public string StrDepartmentId { get; set; }
        public string StrDesignationId { get; set; }
        public DateTime Dob { get; set; }
        public string AboutMe { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public bool IsMale { get; set; }
        public bool IsFeMale { get; set; }
        public JobDetailModel[] JobDetail { get; set; }
    }

    public class JobDetailModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? ReleavingDate { get; set; }
        public int LeavesAllocated { get; set; }
        public int? ReportingTo { get; set; }
        public string StrReportingTo { get; set; }
        public string EmailAlertTo { get; set; }
        public string PreviousCompany { get; set; }
        public int? PreviousExp { get; set; }
    }
}

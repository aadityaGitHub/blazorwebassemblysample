using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using AutoMapper;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly AttendancetrackContext _attendancetrackContext;
        private readonly IMapper _mapper;

        public ReportRepository(AttendancetrackContext attendancetrackContext, IMapper mapper)
        {
            _attendancetrackContext = attendancetrackContext;
            this._mapper = mapper;
        }

        public async Task<EmployeeLeaveReportModel[]> GetEmployeeLeaveReport(int userId)
        {
            var lst = await _attendancetrackContext.Employee.Select(o => new EmployeeLeaveReportModel()
            {
                CLLeaveCount = o.LeaveRequests.Count(s => s.LeaveTypeId == (int)LeaveTypes.CL),
                SLLeaveCount = o.LeaveRequests.Count(s => s.LeaveTypeId == (int)LeaveTypes.SL),
                EmployeeId = o.Id,
                EmployeeName = o.FirstName + " " + o.LastName,
                Department = o.Department.Name,
                Designation = o.Designation.Name
            }).ToArrayAsync();
            return lst;
        }
    }
}

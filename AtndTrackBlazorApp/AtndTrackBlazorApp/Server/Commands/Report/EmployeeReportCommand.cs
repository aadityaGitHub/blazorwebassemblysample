using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.Report
{
    public class EmployeeReportCommand : IRequest<CommandResult<EmployeeLeaveReportModel[]>>
    {
        public int UserId { get; set; }
    }
}

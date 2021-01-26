using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.LeaveRequest
{
    public class UserNotificationCommand :IRequest<CommandResult<UserNotificationModel[]>>
    {
        public int EmployeeId { get; set; }
    }
}

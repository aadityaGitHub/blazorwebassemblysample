using AtndTrackBlazorApp.Server.Commands.LeaveRequest;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.LeaveRequest
{
    public class UserNotificationHandler : IRequestHandler<UserNotificationCommand, CommandResult<UserNotificationModel[]>>
    {
        private readonly ILeaveRequestRepo _employeeRepo;

        public UserNotificationHandler(ILeaveRequestRepo employeeRepo)
        {
            this._employeeRepo = employeeRepo;
        }
        public async Task<CommandResult<UserNotificationModel[]>> Handle(UserNotificationCommand request, CancellationToken cancellationToken)
        {
            var lst = await _employeeRepo.GetUserNotification(request.EmployeeId).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<UserNotificationModel[]>>(new CommandResult<UserNotificationModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);

        }
    }
}

using AtndTrackBlazorApp.Server.Commands.Employee;
using AtndTrackBlazorApp.Shared.Models;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AtndTrackBlazorApp.Server.Commands;

namespace AtndTrackBlazorApp.Server.Handlers.LeaveRequest
{
    public class LeaveRequestHandler : IRequestHandler<LeaveRequestCommand, CommandResult<LeaveRequestModel[]>>
    {
        private readonly ILeaveRequestRepo _employeeRepo;

        public LeaveRequestHandler(ILeaveRequestRepo employeeRepo)
        {
            this._employeeRepo = employeeRepo;
        }

        public async Task<CommandResult<LeaveRequestModel[]>> Handle(LeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var lst = await _employeeRepo.GetLeaveRequests(request.SearchName).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<LeaveRequestModel[]>>(new CommandResult<LeaveRequestModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
        }
    }
}

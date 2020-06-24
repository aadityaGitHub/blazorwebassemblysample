using AtndTrackBlazorApp.Server.Commands.LeaveRequest;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.LeaveRequest
{
    public class LeaveRequestSaveHandler : IRequestHandler<LeaveRequestSaveCommand, CommandResult<bool>>
    {
        private readonly ILeaveRequestRepo _LeaveRequestRepo;

        public LeaveRequestSaveHandler(ILeaveRequestRepo LeaveRequestRepo)
        {
            this._LeaveRequestRepo = LeaveRequestRepo;
        }

        public async Task<CommandResult<bool>> Handle(LeaveRequestSaveCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var lst = await _LeaveRequestRepo.Save(request.Model).ConfigureAwait(false);
                return await Task.FromResult<CommandResult<bool>>(new CommandResult<bool>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}

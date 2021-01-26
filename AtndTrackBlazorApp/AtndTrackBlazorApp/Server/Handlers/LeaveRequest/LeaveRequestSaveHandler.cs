using AtndTrackBlazorApp.Server.Commands.Employee;
using AtndTrackBlazorApp.Server.Commands.LeaveRequest;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.LeaveRequest
{
    public class LeaveRequestSaveHandler : IRequestHandler<LeaveRequestSaveCommand, CommandResult<bool>>
    {
        private readonly ILeaveRequestRepo _LeaveRequestRepo;
        private readonly IMediator _mediator;

        public LeaveRequestSaveHandler(ILeaveRequestRepo LeaveRequestRepo, IMediator mediator)
        {
            this._LeaveRequestRepo = LeaveRequestRepo;
            this._mediator = mediator;

        }

        public async Task<CommandResult<bool>> Handle(LeaveRequestSaveCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var result = await _LeaveRequestRepo.Save(request.Model).ConfigureAwait(false);
                List<UserNotificationModel> userNotificationModels = new List<UserNotificationModel>();
                var userEmails = request.Model.EamilAlertTo?.Split(";");
                var lst = await _mediator.Send<CommandResult<EmployeeModel[]>>(new EmployeeCommand() { SearchName = string.Empty }).ConfigureAwait(false);
                var lstemployees = lst.ResponseObj.Where(o => userEmails.Any(s => o.Email.ToLower() == s.ToLower())).ToList();
                lstemployees.ForEach(item =>
                {
                    dynamic data = new ExpandoObject();
                    data.LeaveRequestId = result.ToString();
                    userNotificationModels.Add(new UserNotificationModel()
                    {
                        CreatedBy = -1,
                        EmployeeId = item.Id,
                        Message = $"{item.FirstName} {item.LastName} - Raised Leave Request",
                        RawData = System.Text.Json.JsonSerializer.Serialize(data)
                    });
                });
                await _LeaveRequestRepo.SaveUserNotification(userNotificationModels).ConfigureAwait(false);
                return await Task.FromResult<CommandResult<bool>>(new CommandResult<bool>() { Message = "Created successfully", Status = true, ResponseObj = result > 0 }).ConfigureAwait(false);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}

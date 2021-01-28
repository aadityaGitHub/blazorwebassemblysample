using AtndTrackBlazorApp.Server.Commands.Report;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.Report
{
    public class EmployeeReportHandler : IRequestHandler<EmployeeReportCommand, CommandResult<EmployeeLeaveReportModel[]>>
    {
        private readonly IReportRepository _reportRepository;

        public EmployeeReportHandler(IReportRepository reportRepository )
        {
            this._reportRepository = reportRepository;
        }
        public async Task<CommandResult<EmployeeLeaveReportModel[]>> Handle(EmployeeReportCommand request, CancellationToken cancellationToken)
        {
            var result = await _reportRepository.GetEmployeeLeaveReport(request.UserId)
                .ConfigureAwait(false);
            return await Task.FromResult<CommandResult<EmployeeLeaveReportModel[]>>(new CommandResult<EmployeeLeaveReportModel[]>()
            { Message = "Created successfully", Status = true, ResponseObj = result }).ConfigureAwait(false);
        }
    }
}

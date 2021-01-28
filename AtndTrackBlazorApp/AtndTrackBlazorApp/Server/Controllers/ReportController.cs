using AtndTrackBlazorApp.Server.Commands.Report;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        // GET: api/Organization
        public async Task<EmployeeLeaveReportModel[]> Get(int userId)
        {
            var lst = await _mediator.Send<CommandResult<EmployeeLeaveReportModel[]>>(new EmployeeReportCommand() { UserId = userId }).ConfigureAwait(false);
            return lst.ResponseObj; 
        }

    }
}

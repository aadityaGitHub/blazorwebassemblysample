using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtndTrackBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        // GET: api/Organization
        [HttpGet("departments")]
        public async Task<IEnumerable<DepartmentModel>> Get()
         {
            var lst = await _mediator.Send<CommandResult<DepartmentModel[]>>(new DepartmentCommand() { SearchName = string.Empty }).ConfigureAwait(false);
            return lst.ResponseObj; //?.ResponseObj as IEnumerable<DepartmentModel>;
        }

        [HttpPost("savedepartment")]
        public async Task<bool> SaveDepartment(DepartmentModel departmentModel)
        {
            var result = await _mediator.Send<CommandResult<bool>>(new DepartmentSaveCommand() { Model = departmentModel }).ConfigureAwait(false);
            return result.ResponseObj;
        }

        // GET: api/Organization
        [HttpGet("designations")]
        public async Task<IEnumerable<DesignationModel>> GetDesignations()
        {
            var lst = await _mediator.Send<CommandResult<DesignationModel[]>>(new DesignationCommand() { SearchName = string.Empty }).ConfigureAwait(false);
            return lst.ResponseObj; //?.ResponseObj as IEnumerable<DesignationModel>;
        }

        [HttpPost("savedesignation")]
        public async Task<bool> SaveDesignation(DesignationModel DesignationModel)
        {
            var result = await _mediator.Send<CommandResult<bool>>(new DesignationSaveCommand() { Model = DesignationModel }).ConfigureAwait(false);
            return result.ResponseObj;
        }
    }
}

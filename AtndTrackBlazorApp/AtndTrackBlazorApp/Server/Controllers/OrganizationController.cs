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
            var result = await _mediator.Send<CommandResult<bool>>(new DepartmentSaveCommand<bool>() { Model = departmentModel }).ConfigureAwait(false);
            return result.ResponseObj;
        }

        // GET: api/Organization/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Organization
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Organization/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

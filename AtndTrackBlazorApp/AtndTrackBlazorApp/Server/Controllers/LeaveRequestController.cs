using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Server.Commands.LeaveRequest;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtndTrackBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class LeaveRequestController : Controller
    {
        private readonly IMediator _mediator;

        public LeaveRequestController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<LeaveRequestModel>> Get()
        {
            var lst = await _mediator.Send<CommandResult<LeaveRequestModel[]>>(new LeaveRequestCommand() { SearchName = string.Empty }).ConfigureAwait(false);
            return lst.ResponseObj; //?.ResponseObj as IEnumerable<DesignationModel>;

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<LeaveRequestModel> Get(int id)
        {
            var lst = await _mediator.Send<CommandResult<LeaveRequestModel[]>>(new LeaveRequestCommand() { SearchName = string.Empty }).ConfigureAwait(false);
            return lst.ResponseObj.FirstOrDefault(o => o.Id == id); //?.ResponseObj as IEnumerable<DesignationModel>;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task<bool> Post([FromBody]LeaveRequestModel value)
        {
            var lst = await _mediator.Send<CommandResult<bool>>(new LeaveRequestSaveCommand() { Model = value }).ConfigureAwait(false);
            return lst.ResponseObj; //?.ResponseObj as IEnumerable<DesignationModel>;

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

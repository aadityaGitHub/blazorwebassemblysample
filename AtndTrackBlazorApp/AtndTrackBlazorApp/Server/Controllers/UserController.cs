using AtndTrackBlazorApp.Server.Commands.User;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtndTrackBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task< IEnumerable<UserModel>> Get()
        {
            var lst = await _mediator.Send<CommandResult<UserModel[]>>(new UserCommand() { SearchName = string.Empty }).ConfigureAwait(false);
            return lst.ResponseObj; //?.ResponseObj as IEnumerable<DesignationModel>;

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<bool> Post([FromBody] UserModel value)
        {
            var lst = await _mediator.Send<CommandResult<bool>>(new UserSaveCommand() { Model = value }).ConfigureAwait(false);
            return lst.ResponseObj; 

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

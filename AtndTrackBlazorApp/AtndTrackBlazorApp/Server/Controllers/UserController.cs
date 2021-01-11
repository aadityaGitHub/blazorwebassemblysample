using AtndTrackBlazorApp.Server.Commands.User;
using AtndTrackBlazorApp.Server.Services;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtndTrackBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IEmailService _emailService;

        public UserController(IMediator mediator, IEmailService emailService)
        {
            this._mediator = mediator;
            this._emailService = emailService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<UserModel>> Get()
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
            var response = await _mediator.Send<CommandResult<bool>>(new UserSaveCommand() { Model = value }).ConfigureAwait(false);
            if (response?.ResponseObj ?? false)
            {
                SendMail(value.Email, "User Activation Email");
            }
            return response.ResponseObj;

        }

        private void SendMail(string userEmail, string subject)
        {
            try
            {

                StringBuilder stringBuilder = new StringBuilder();
                using (StreamReader reader = new StreamReader(Path.Combine("Templates", "AddUser.html")))
                {
                    stringBuilder.Append(reader.ReadToEnd());
                }
                _emailService.Send(userEmail, subject, stringBuilder.ToString());
            }
            catch (Exception ex)
            {

                throw;
            }
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

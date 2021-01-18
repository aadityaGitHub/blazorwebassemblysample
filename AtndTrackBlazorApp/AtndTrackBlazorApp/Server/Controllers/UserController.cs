using AtndTrackBlazorApp.Server.Commands.User;
using AtndTrackBlazorApp.Server.Services;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Helpers;
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
        public async Task<CommandResult<int>> Post([FromBody] UserModel value)
        {
            var response = await _mediator.Send<CommandResult<int>>(new UserSaveCommand() { Model = value }).ConfigureAwait(false);
            if (response?.ResponseObj>0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                using (StreamReader reader = new StreamReader(Path.Combine("Templates", Constants.AddUserTemplate)))
                {
                    stringBuilder.Append(reader.ReadToEnd());
                }
                var mailContent = stringBuilder.ToString();
                mailContent = mailContent.Replace("{0}", $"{value.ClientUrl}useractivation/{response.ResponseObj}?messageGuid={Guid.NewGuid()}");
                SendMail(value.Email, "User Activation Email", mailContent);
            }
            return response;

        }

        private void SendMail(string userEmail, string subject, string mailContent)
        {
            try
            {
                _emailService.Send(userEmail, subject, mailContent);
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

        // DELETE api/<UserController>/5
        [HttpGet("useractivation/{id}")]
        public async Task<CommandResult<bool>> ActivateUser(int id)
        {
            return await _mediator.Send<CommandResult<bool>>(new ActivateUserCommand() { UserId = id }).ConfigureAwait(false);
        }
    }
}

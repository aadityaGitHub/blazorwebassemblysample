using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.User
{
    public class AuthenticateUserCommand : IRequest<AuthUserModel>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

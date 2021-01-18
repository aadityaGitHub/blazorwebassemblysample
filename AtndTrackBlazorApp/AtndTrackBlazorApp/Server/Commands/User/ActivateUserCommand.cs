using AtndTrackBlazorApp.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.User
{
    public class ActivateUserCommand : IRequest<CommandResult<bool>>
    {
        public int UserId { get; set; }
    }
}

using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.User
{
    public class UserSaveCommand : IRequest<CommandResult<bool>>
    {
        public UserModel Model { get; set; }
    }
}

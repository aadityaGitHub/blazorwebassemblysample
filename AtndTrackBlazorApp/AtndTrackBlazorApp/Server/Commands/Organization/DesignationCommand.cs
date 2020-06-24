using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands
{
    public class DesignationCommand :IRequest<CommandResult<DesignationModel[]>>
    {
        public string SearchName { get; set; }
    }
}

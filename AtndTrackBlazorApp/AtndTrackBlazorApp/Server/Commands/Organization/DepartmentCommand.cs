using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands
{
    public class DepartmentCommand :IRequest<CommandResult<DepartmentModel[]>>
    {
        public string SearchName { get; set; }
    }
}

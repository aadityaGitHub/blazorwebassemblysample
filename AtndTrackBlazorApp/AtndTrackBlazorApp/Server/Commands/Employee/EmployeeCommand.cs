using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.Employee
{
    public class EmployeeCommand : IRequest<CommandResult<EmployeeModel[]>>
    {
        public string SearchName { get; set; }
    }
}

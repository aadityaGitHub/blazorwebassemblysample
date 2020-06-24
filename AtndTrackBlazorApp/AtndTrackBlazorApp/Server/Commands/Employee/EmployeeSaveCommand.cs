using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands.Employee
{
    public class EmployeeSaveCommand : IRequest<CommandResult<bool>>
    {
        public EmployeeModel Model { get; set; }
    }
}
using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers
{
    public class DepartmentHandler : IRequestHandler<DepartmentCommand, CommandResult<DepartmentModel[]>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public DepartmentHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }

        public async Task<CommandResult<DepartmentModel[]>> Handle(DepartmentCommand request, CancellationToken cancellationToken)
        {
            var lst= await organizationRepo.GetDepartments(request.SearchName).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<DepartmentModel[]>>( new CommandResult<DepartmentModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst}).ConfigureAwait(false);
        }
    }
}

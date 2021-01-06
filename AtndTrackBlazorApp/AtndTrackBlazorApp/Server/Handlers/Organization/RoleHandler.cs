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
    public class RoleHandler : IRequestHandler<RoleCommand, CommandResult<RoleModel[]>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public RoleHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }

        public async Task<CommandResult<RoleModel[]>> Handle(RoleCommand request, CancellationToken cancellationToken)
        {
            var lst = await organizationRepo.GetRoles(request.SearchName).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<RoleModel[]>>(new CommandResult<RoleModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
        }
    }
}

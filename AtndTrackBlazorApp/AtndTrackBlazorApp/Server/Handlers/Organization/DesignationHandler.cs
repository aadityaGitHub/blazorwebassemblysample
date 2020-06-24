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
    public class DesignationHandler : IRequestHandler<DesignationCommand, CommandResult<DesignationModel[]>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public DesignationHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }

        public async Task<CommandResult<DesignationModel[]>> Handle(DesignationCommand request, CancellationToken cancellationToken)
        {
            var lst = await organizationRepo.GetDesignations(request.SearchName).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<DesignationModel[]>>(new CommandResult<DesignationModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
        }
    }
}

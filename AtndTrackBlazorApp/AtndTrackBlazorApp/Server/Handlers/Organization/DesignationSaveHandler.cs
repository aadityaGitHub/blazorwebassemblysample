using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers
{
    public class DesignationSaveHandler : IRequestHandler<DesignationSaveCommand, CommandResult<bool>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public DesignationSaveHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }
        public async Task<CommandResult<bool>> Handle(DesignationSaveCommand request, CancellationToken cancellationToken)
        {
            var result = await organizationRepo.SaveDesignation(request.Model).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<bool>>(new CommandResult<bool>() { Message = "Created successfully", Status = result }).ConfigureAwait(false);
        }
    }
}

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
    public class DepartmentSaveHandler<T> : IRequestHandler<DepartmentSaveCommand<T>, CommandResult<T>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public DepartmentSaveHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }
        public async Task<CommandResult<T>> Handle(DepartmentSaveCommand<T> request, CancellationToken cancellationToken)
        {
            var result= await organizationRepo.Save(request.Model).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<T>>(new CommandResult<T>() { Message = "Created successfully", Status = true }).ConfigureAwait(false);
        }
    }
}

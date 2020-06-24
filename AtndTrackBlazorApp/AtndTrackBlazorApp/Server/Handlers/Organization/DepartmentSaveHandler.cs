using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers
{
    public class DepartmentSaveHandler : IRequestHandler<DepartmentSaveCommand, CommandResult<bool>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public DepartmentSaveHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }
        public async Task<CommandResult<bool>> Handle(DepartmentSaveCommand request, CancellationToken cancellationToken)
        {
            var result= await organizationRepo.Save(request.Model).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<bool>>(new CommandResult<bool>() { Message = "Created successfully", Status = result }).ConfigureAwait(false);
        }
    }
}

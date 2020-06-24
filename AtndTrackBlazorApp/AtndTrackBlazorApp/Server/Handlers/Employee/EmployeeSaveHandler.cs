using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Server.Commands.Employee;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.Employee
{
    public class EmployeeSaveHandler : IRequestHandler<EmployeeSaveCommand, CommandResult<bool>>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeSaveHandler(IEmployeeRepo employeeRepo)
        {
            this._employeeRepo = employeeRepo;
        }

        public async Task<CommandResult<bool>> Handle(EmployeeSaveCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var lst = await _employeeRepo.Save(request.Model).ConfigureAwait(false);
                return await Task.FromResult<CommandResult<bool>>(new CommandResult<bool>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}

using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Server.Commands.Employee;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using DataAccess.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.Employee
{
    public class EmployeeHandler : IRequestHandler<EmployeeCommand, CommandResult<EmployeeModel[]>>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeHandler(IEmployeeRepo employeeRepo)
        {
            this._employeeRepo = employeeRepo;
        }

        public async Task<CommandResult<EmployeeModel[]>> Handle(EmployeeCommand request, CancellationToken cancellationToken)
        {
            var lst = await _employeeRepo.GetEmployees(request.SearchName).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<EmployeeModel[]>>(new CommandResult<EmployeeModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
        }
    }
}

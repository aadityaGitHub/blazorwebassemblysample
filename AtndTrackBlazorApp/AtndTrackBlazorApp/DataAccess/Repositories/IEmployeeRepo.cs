using AtndTrackBlazorApp.Shared.Models;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IEmployeeRepo
    {
        Task<EmployeeModel[]> GetEmployees(string name);
        Task<bool> Save(EmployeeModel EmployeeModel);
        Task<EmployeeModel> GetEmployee(int employeeId);
    }
}
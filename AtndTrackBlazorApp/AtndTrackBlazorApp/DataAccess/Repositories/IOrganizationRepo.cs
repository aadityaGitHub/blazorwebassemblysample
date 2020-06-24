using AtndTrackBlazorApp.Shared.Models;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IOrganizationRepo
    {
        Task<DepartmentModel[]> GetDepartments(string name);
        Task<DesignationModel[]> GetDesignations(string name);
        Task<bool> Save(DepartmentModel departmentModel);
        Task<bool> SaveDesignation(DesignationModel departmentModel);
    }
}
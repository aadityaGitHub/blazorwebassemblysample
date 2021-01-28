using AtndTrackBlazorApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IReportRepository
    {
        Task<EmployeeLeaveReportModel[]> GetEmployeeLeaveReport(int userId);
    }
}
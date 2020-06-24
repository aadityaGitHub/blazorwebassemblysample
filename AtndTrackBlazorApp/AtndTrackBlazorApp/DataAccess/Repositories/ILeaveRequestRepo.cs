using AtndTrackBlazorApp.Shared.Models;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ILeaveRequestRepo
    {
        Task<LeaveRequestModel> GetLeaveRequest(int LeaveRequestId);
        Task<LeaveRequestModel[]> GetLeaveRequests(string name);
        Task<bool> Save(LeaveRequestModel leaveRequestModel);
    }
}
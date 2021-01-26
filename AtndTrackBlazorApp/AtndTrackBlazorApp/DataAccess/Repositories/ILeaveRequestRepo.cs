using AtndTrackBlazorApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ILeaveRequestRepo
    {
        Task<LeaveRequestModel> GetLeaveRequest(int LeaveRequestId);
        Task<LeaveRequestModel[]> GetLeaveRequests(string name);
        Task<int> Save(LeaveRequestModel leaveRequestModel);
        Task<bool> SaveUserNotification(List<UserNotificationModel> userNotificationModels);
        Task<UserNotificationModel[]> GetUserNotification(int employeeId);
    }
}
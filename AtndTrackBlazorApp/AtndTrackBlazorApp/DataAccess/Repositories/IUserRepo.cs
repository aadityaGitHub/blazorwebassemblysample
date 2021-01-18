using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Shared.Models;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IUserRepo
    {
        Task<UserModel[]> GetUsers(string name);
        Task<int> Save(UserModel user);
        Task<bool> ActivateUser(int userId);
    }
}
using AtndTrackBlazorApp.Shared.Models;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IUserRepo
    {
        Task<UserModel[]> GetUsers(string name);
        Task<bool> Save(UserModel user);
    }
}
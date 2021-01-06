using AtndTrackBlazorApp.Shared.Models;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AtndTrackBlazorApp.Server.Commands.User;

namespace AtndTrackBlazorApp.Server.Handlers.User
{
    public class UserHandler : IRequestHandler<UserCommand, CommandResult<UserModel[]>>
    {
        private readonly IUserRepo _repo;

        public UserHandler(IUserRepo repo)
        {
            this._repo = repo;
        }

        public async Task<CommandResult<UserModel[]>> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            var lst = await _repo.GetUsers(request.SearchName).ConfigureAwait(false);
            return await Task.FromResult<CommandResult<UserModel[]>>(new CommandResult<UserModel[]>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
        }
    }
}

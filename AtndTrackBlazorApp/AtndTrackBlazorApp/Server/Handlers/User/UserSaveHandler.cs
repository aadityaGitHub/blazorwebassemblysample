using AtndTrackBlazorApp.Server.Commands.User;
using AtndTrackBlazorApp.Shared;
using DataAccess.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Handlers.User
{
    public class UserSaveHandler : IRequestHandler<UserSaveCommand, CommandResult<int>>
    {
        private readonly IUserRepo _repo;

        public UserSaveHandler(IUserRepo repo)
        {
            this._repo = repo;
        }

        public async Task<CommandResult<int>> Handle(UserSaveCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var userId = await _repo.Save(request.Model).ConfigureAwait(false);
                return await Task.FromResult<CommandResult<int>>(new CommandResult<int>() { Message = "Created successfully", Status = true, ResponseObj = userId }).ConfigureAwait(false);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}

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
    public class UserSaveHandler : IRequestHandler<UserSaveCommand, CommandResult<bool>>
    {
        private readonly IUserRepo _repo;

        public UserSaveHandler(IUserRepo repo)
        {
            this._repo = repo;
        }

        public async Task<CommandResult<bool>> Handle(UserSaveCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _repo.Save(request.Model).ConfigureAwait(false);
                return await Task.FromResult<CommandResult<bool>>(new CommandResult<bool>() { Message = "Created successfully", Status = true, ResponseObj = lst }).ConfigureAwait(false);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}

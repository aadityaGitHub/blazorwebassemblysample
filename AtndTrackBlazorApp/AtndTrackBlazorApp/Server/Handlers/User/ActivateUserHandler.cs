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
    public class ActivateUserHandler : IRequestHandler<ActivateUserCommand, CommandResult<bool>>
    {
        private readonly IUserRepo _repo;

        public ActivateUserHandler(IUserRepo repo)
        {
            this._repo = repo;
        }
        public async Task<CommandResult<bool>> Handle(ActivateUserCommand request, CancellationToken cancellationToken)
        {
            var res= await _repo.ActivateUser(request.UserId).ConfigureAwait(false);
            return new CommandResult<bool>() { Message = res ? "User Activated Successfully." : "Error occurred. Please try again", ResponseObj = true, Status = true };
        }
    }
}

using DataAccess.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands
{
    public interface ICreateCommand<TEntity> : IRequest<bool> where TEntity : Departments, new() { }

    public class CreateCommandHandler<TEntity, TCommand> : IRequestHandler<TCommand, bool>
        where TEntity : Departments, new()
        where TCommand : class, ICreateCommand<TEntity>, new()
    {
       
        public Task<bool> Handle(TCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

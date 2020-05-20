using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands
{
    public interface ICommand<T>
    {
        CommandResult<T> Handle();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands
{
    public class OrgnizationHandler : IOrgnizationHandler<DeptCommand>
    {
        public int MyProperty { get; set; }

        public CommandResult<DeptCommand> Handle(DeptCommand command)
        {
            return new CommandResult<DeptCommand>();
        }                                                              
    }
}

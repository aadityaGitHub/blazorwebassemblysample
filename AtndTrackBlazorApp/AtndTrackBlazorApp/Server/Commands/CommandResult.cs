using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Server.Commands
{
    public class CommandResult
    {
        
        public string Message { get; set; }
        public bool Status { get; set; }
        public object ResponseObj { get; set; }
    }
}

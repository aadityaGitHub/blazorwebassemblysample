using AtndTrackBlazorApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtndTrackBlazorApp.Shared
{
    public class CommandResult<T>
    {

        public string Message { get; set; }
        public bool Status { get; set; }
        public T ResponseObj { get; set; }
    }
}

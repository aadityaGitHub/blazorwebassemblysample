using System;
using System.Collections.Generic;
using System.Text;

namespace AtndTrackBlazorApp.Shared
{
    public enum LeaveTypes
    {
        CL=1,
        SL=2,
        CF=3
    }

    public enum LeaveStatusTypes
    {
        Created,
        Pending,
        Approved,
        Declined
    }
    public enum RoleTypes
    {
        Admin,
        SuperAdmin,
        Employee,
        TeamLead
    }
}

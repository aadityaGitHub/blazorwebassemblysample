﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Roles
    {
        public Roles()
        {
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
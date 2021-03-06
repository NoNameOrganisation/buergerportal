﻿using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace mosPortal.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public ICollection<UserRole> UserRole { get; set; }
    }
}

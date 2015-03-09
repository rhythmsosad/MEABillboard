using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MEABillboardWeb.Models
{
    public class MEABillboardContext : DbContext
    {
        public MEABillboardContext()
            : base()
        {

        }

        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<AuthUserGroup> AuthUserGroups { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MEABillboardWeb.Models
{
    public class MEABillboardDBInitializer : DropCreateDatabaseAlways<MEABillboardContext>
    {
        protected override void Seed(MEABillboardContext context)
        {
            IList<AuthUser> defaultAuthUser = new List<AuthUser>();

            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName1", LastName = "LastName1" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName2", LastName = "LastName2" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName3", LastName = "LastName3" });

            foreach (AuthUser std in defaultAuthUser)
                context.AuthUsers.Add(std);

            base.Seed(context);
        }
    }
}
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
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName4", LastName = "LastName4" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName5", LastName = "LastName5" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName6", LastName = "LastName6" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName7", LastName = "LastName7" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName8", LastName = "LastName8" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName9", LastName = "LastName9" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName10", LastName = "LastName10" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName11", LastName = "LastName11" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName12", LastName = "LastName12" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName13", LastName = "LastName13" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName14", LastName = "LastName14" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName15", LastName = "LastName15" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName16", LastName = "LastName16" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName17", LastName = "LastName17" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName18", LastName = "LastName18" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName19", LastName = "LastName19" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName20", LastName = "LastName20" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName21", LastName = "LastName21" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName22", LastName = "LastName22" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName23", LastName = "LastName23" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName24", LastName = "LastName24" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName25", LastName = "LastName25" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName26", LastName = "LastName26" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName27", LastName = "LastName27" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName28", LastName = "LastName28" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName29", LastName = "LastName29" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName30", LastName = "LastName30" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName31", LastName = "LastName31" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName32", LastName = "LastName32" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName33", LastName = "LastName33" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName34", LastName = "LastName34" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName35", LastName = "LastName35" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName36", LastName = "LastName36" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName37", LastName = "LastName37" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName38", LastName = "LastName38" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName39", LastName = "LastName39" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName40", LastName = "LastName40" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName41", LastName = "LastName41" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName42", LastName = "LastName42" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName43", LastName = "LastName43" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName44", LastName = "LastName44" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName45", LastName = "LastName45" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName46", LastName = "LastName46" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName47", LastName = "LastName47" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName48", LastName = "LastName48" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName49", LastName = "LastName49" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName50", LastName = "LastName50" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName51", LastName = "LastName51" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName52", LastName = "LastName52" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName53", LastName = "LastName53" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName54", LastName = "LastName54" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName55", LastName = "LastName55" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName56", LastName = "LastName56" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName57", LastName = "LastName57" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName58", LastName = "LastName58" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName59", LastName = "LastName59" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName60", LastName = "LastName60" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName61", LastName = "LastName61" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName62", LastName = "LastName62" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName63", LastName = "LastName63" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName64", LastName = "LastName64" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName65", LastName = "LastName65" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName66", LastName = "LastName66" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName67", LastName = "LastName67" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName68", LastName = "LastName68" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName69", LastName = "LastName69" });
            defaultAuthUser.Add(new AuthUser() { FirstName = "FirstName70", LastName = "LastName70" });

            foreach (AuthUser item in defaultAuthUser)
            {
                context.AuthUsers.Add(item);
            }

            base.Seed(context);
        }
    }
}
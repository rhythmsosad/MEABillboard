using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEABillboardWeb.Areas.Admin.Models
{
    public class AdminUser
    {
        public AdminUserItem Find(int id)
        {
            return new AdminUserItem();
        }
    }

    public class AdminUserItem
    {
        public int userId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string UserAccount { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        //public string ConfirmPassword { get; set; }
    }

   
}
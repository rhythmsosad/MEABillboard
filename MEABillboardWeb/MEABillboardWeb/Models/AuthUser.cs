using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MEABillboardWeb.Models
{
    public class AuthUser
    {
        public AuthUser()
        {

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Branch { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public string CreatedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedDate { get; set; }


        // CRUD
        public List<AuthUser> Query()
        {
            using (var context = new MEABillboardContext())
            {
                var list = from o in context.AuthUsers
                           select o;
                return list.ToList();
            }
        }

        public void Add()
        {
            using(var context = new MEABillboardContext())
            {
                context.AuthUsers.Add(this);
                context.SaveChanges();
            }
        }
    }
}
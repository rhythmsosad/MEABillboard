using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Models
{
    public class AuthUserGroup
    {
        public AuthUserGroup()
        {

        }

        //GUID
        //FN_NAME
        //NAME
        //USER_CNT
        //ALLNAMELIST
        //NAMELIST
        //FUNCTIONLIST
        //FUNCTION
        //ALLNAME
        //SNAME

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }
        public string FunctionName { get; set; }
        public string UserGroupName { get; set; }
        public int UserCount { get; set; }
        //public string AllNameList { get; set; }
        //public string NameList { get; set; }
        //public string FunctionList { get; set; }
        public string Function { get; set; }
        public string AllName { get; set; }
        public string UserInGroup { get; set; }

        //  public List<SelectListItem> ALLNAMELIST { set; get; }
        //public List<SelectListItem> NAMELIST { set; get; }
        //public List<SelectListItem> FUNCTIONLIST { set; get; }

        public int[] ALLNAME { set; get; }
        public int[] SNAME { set; get; }

        public int[] FAKE_ALLNAME { set; get; }
        public int[] FAKE_SNAME { set; get; }

        public void Add()
        {
            using (var context = new MEABillboardContext())
            {
                context.AuthUserGroups.Add(this);
                context.SaveChanges();
            }
        }

        public List<SelectListItem> AllNameList()
        {
            var lst = new List<SelectListItem>();
            for (int i = 1; i <= 10; i++)
            {
                if (SNAME == null || !SNAME.Contains(i))
                    lst.Add(new SelectListItem() { Text = string.Format("Name_{0}", i), Value = i.ToString() });
            }

            return lst;
        }
        public List<SelectListItem> NameList()
        {
            var lst = new List<SelectListItem>();
            for (int i = 1; i <= 10; i++)
            {
                if (SNAME != null && SNAME.Contains(i))
                    lst.Add(new SelectListItem() { Text = string.Format("Name_{0}", i), Value = i.ToString() });
            }

            return lst;
        }
        public List<SelectListItem> FunctionList()
        {
            var lst = new List<SelectListItem>();
            for (int i = 1; i <= 10; i++)
                lst.Add(new SelectListItem() { Text = string.Format("function_{0}", i), Value = i.ToString() });

            return lst;
        }


    }
}
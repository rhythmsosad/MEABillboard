using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEABillboardWeb.Areas.Admin.Models
{
    public class AdminFunction
    {
        public AdminFunctionItem Find(int id)
        {
            return new AdminFunctionItem();
        }
    }

    public class AdminFunctionItem
    {
        public string Code { get; set; }
        public string Menu { get; set; }
        public string FileDir { get; set; }
        public string Icon { get; set; }
        public string Order { get; set; }
        public string Status { get; set; }
    }

}
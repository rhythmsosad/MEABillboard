﻿using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Admin_default",
            //    "Admin/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional },
            //    new[] { "MEABillboardWeb.Areas.Admin.Controllers" }
            //);

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "MEABillboardWeb.Areas.Admin.Controllers" }
            );
        }
    }
}
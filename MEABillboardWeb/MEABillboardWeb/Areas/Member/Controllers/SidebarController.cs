using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Member.Controllers
{
    public class SidebarController : Controller
    {
        // GET: Member/Menu
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Partial view ส่วนแสดงเมนู
        /// </summary>
        /// <returns></returns>
        public ViewResult Menu()
        {
            return View();
        }


        /// <summary>
        /// Partial view ส่วนแสดงข้อมูล sidebar
        /// </summary>
        /// <returns></returns>
        public ViewResult Sidebar()
        {
            return View();
        }
    }
}
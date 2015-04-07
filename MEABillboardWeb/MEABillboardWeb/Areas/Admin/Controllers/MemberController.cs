using MEABillboardWeb.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin.Controllers
{
    public class MemberController : Controller
    {
        // GET: Admin/Member
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Dummy model)
        {
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Member.Controllers
{
    public class LoginController : Controller
    {
        // GET: Member/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            return RedirectToAction("Index", "Profile");
        }
    }
}
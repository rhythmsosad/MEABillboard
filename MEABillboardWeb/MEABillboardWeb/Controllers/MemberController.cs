using MEABillboardWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Dummy model)
        {
            return RedirectToAction("Index", "Profile", new { area = "" });
        }
    }
}
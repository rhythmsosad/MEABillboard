using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Member/Profile
        public ActionResult Index()
        {
            return View();
        }
    }
}
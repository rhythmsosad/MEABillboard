using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin.Controllers
{
    public class MediaController : Controller
    {
        // GET: Admin/Media
        public ActionResult Index()
        {
            return View();
        }
    }
}
using MEABillboardWeb.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin.Controllers
{
    public class AdminUserController : Controller
    {
        // GET: Admin/AdminUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            int id = 1;
            AdminUser modelCollection = new AdminUser();
            AdminUserItem model = modelCollection.Find(id);
            return View(model);
        }
    }
}
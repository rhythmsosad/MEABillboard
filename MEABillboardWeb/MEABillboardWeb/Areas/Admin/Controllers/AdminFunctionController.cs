using MEABillboardWeb.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin.Controllers
{
    public class AdminFunctionController : Controller
    {
        // GET: Admin/AdminFunction
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form()
        {
            int id = 1;
            AdminFunction modelCollection = new AdminFunction();
            AdminFunctionItem model = modelCollection.Find(id);
            return View(model);
        }
    }
}
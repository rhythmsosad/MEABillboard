using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin.Controllers
{
    public class ContractController : Controller
    {
        // GET: Admin/Contract
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Contract
        public ActionResult Form()
        {
            return View();
        }
    }
}
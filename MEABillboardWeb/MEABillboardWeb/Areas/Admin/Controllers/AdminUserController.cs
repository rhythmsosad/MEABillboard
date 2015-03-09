
using MEABillboardWeb.Models;
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
            AuthUser item = new AuthUser();
            return View(item);
        }

        public ActionResult Form()
        {
            AuthUser modelCollection = new AuthUser();
            return View(modelCollection);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Form(AuthUser model)
        {
            model.CreatedBy = "Chin";
            model.ModifiedBy = "Chin";
            model.Add();

            return Redirect(Url.Action("Form", "AdminUser"));
        }
    }
}
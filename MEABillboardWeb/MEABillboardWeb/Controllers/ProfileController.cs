using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// แสดงรายละเอียดสัญญา
        /// </summary>
        /// <returns></returns>
        public ActionResult Contract()
        {
            return View();
        }

        /// <summary>
        /// แสดงรายละเอียดสัญญา
        /// </summary>
        /// <returns></returns>
        public ActionResult ContractInfo()
        {
            return View();
        }

        public ActionResult Media()
        {
            return View();
        }

        public ActionResult MediaInfo()
        {
            return View();
        }

        /// <summary>
        /// แสดงรายละเอียดป้าย
        /// </summary>
        /// <returns></returns>
        public ActionResult BoardInfo()
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
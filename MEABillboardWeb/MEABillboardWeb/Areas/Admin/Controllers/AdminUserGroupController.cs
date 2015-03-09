using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEABillboardWeb.Areas.Admin.Controllers
{
    public class AdminUserGroupController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {

            return View(new MEABillboardWeb.Models.AuthUserGroup());
        }

        [HttpPost]
        public JsonResult Form(string fnList)
        {
            try
            {
                //umUserGroup.Add();
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }



        // GET: UMUserGroup
        //public ActionResult Index()
        //{
        //    PTT_Forest.Models.Datasets.UMUserGroup.UM_Q_GROUP_USER_TBLDataTable dt = new PTT_Forest.Models.Datasets.UMUserGroup.UM_Q_GROUP_USER_TBLDataTable();
        //    UM_Q_GROUP_USER_TBLTableAdapter ta = new UM_Q_GROUP_USER_TBLTableAdapter();

        //    object poData = new object();
        //    decimal? poStatus = -1;
        //    string poStatusMsg = string.Empty;

        //    int result = ta.Fill(dt, null, out poData, out poStatus, out poStatusMsg);

        //    if (poStatus == 1)
        //    {
        //        //Pass    
        //        ConfigDT config = new ConfigDT();

        //        List<ColumnDT> columnList = new List<ColumnDT>();
        //        columnList.Add(new ColumnDT { Data = "GUID", Title = "รหัส" });
        //        columnList.Add(new ColumnDT { Data = "NAME", Title = "ชื่อกลุ่มผู้ใช้งาน" });
        //        columnList.Add(new ColumnDT { Data = "GFID", Title = "รหัสกลุ่มเมนู" });
        //        columnList.Add(new ColumnDT { Data = "FN_NAME", Title = "ชื่อกลุ่มเมนู" });
        //        columnList.Add(new ColumnDT { Data = "USER_CNT", Title = "จำนวนผู้ใช้งาน" });

        //        List<ButtonDT> buttonList = new List<ButtonDT>();
        //        buttonList.Add(new ButtonDT { Name = "Edit", Icon = "glyphicon glyphicon-pencil", IconType = "Icon" });
        //        buttonList.Add(new ButtonDT { Name = "Delete", Icon = "glyphicon glyphicon-remove-circle", IconType = "Icon" });

        //        config.Data = dt;
        //        config.Key = "GUID";
        //        config.ColumnList = columnList;
        //        config.ButtonList = buttonList;
        //        config.InvisbleColumn = new int[] { 0, 2 };
        //        config.ImageColumn = new int[] { };

        //        ViewBag.dataTableConfig = config;

        //    }
        //    else if (poStatus == 0)
        //    {
        //        //Fail
        //    }

        //    return View();
        //}

        //public ActionResult Insert()
        //{
        //    ViewBag.Title = "เพิ่มกลุ่มผู้ใช้งาน";
        //    return PartialView("Insert");
        //}

        //[HttpPost]
        //public JsonResult Insert(UMUserGroup umUserGroup)
        //{
        //    UM_Q_GROUP_USERTableAdapter ta = new UM_Q_GROUP_USERTableAdapter();

        //    string id = string.Empty;
        //    decimal? poStatus = -1;
        //    string poStatusMsg = string.Empty;

        //    int result = ta.UM_I_GROUP_USER(umUserGroup.NAME, out id, out poStatus, out poStatusMsg);

        //    if (poStatus == 1)
        //    {
        //        string title = "ข้อความแจ้งเตือน";
        //        string message = "เพิ่มข้อมูล กลุ่มผู้ใช้งาน " + umUserGroup.NAME + " เรียบร้อย";
        //        return Json(new { success = true, dialog = new { title = title, message = message } });
        //    }
        //    else
        //    {
        //        if (poStatusMsg == "duplicate")
        //        {
        //            string title = "เกิดข้อผิดพลาด";
        //            string message = "ไม่สามารถเพิ่มข้อมูล เนื่องจากกลุ่ม " + umUserGroup.NAME + " ซ้ำ";
        //            return Json(new { success = false, dialog = new { title = title, message = message } });
        //        }
        //        else
        //        {
        //            string title = "เกิดข้อผิดพลาด";
        //            string message = poStatusMsg;
        //            return Json(new { success = false, dialog = new { title = title, message = message } });
        //        }
        //    }
        //}

        //public ActionResult Detail(string id, string type, string data)
        //{
        //    if (type == "Delete")
        //    {
        //        JavaScriptSerializer serializer = new JavaScriptSerializer();
        //        dynamic item = serializer.Deserialize<object>(data);

        //        UMUserGroup umUserGroup = new UMUserGroup();
        //        umUserGroup.GUID = id;
        //        umUserGroup.NAME = item["NAME"];

        //        ViewBag.Title = "ลบกลุ่มผู้ใช้งาน";
        //        return PartialView("Delete", umUserGroup);
        //    }
        //    else
        //    {
        //        JavaScriptSerializer serializer = new JavaScriptSerializer();
        //        dynamic item = serializer.Deserialize<object>(data);

        //        UMUserGroup umUserGroup = new UMUserGroup();
        //        umUserGroup.GUID = id;
        //        umUserGroup.NAME = item["NAME"];
        //        if (item["GFID"] != null)
        //        {
        //            umUserGroup.FUNCTION = Int32.Parse(item["GFID"]);
        //        }

        //        PTT_Forest.Models.Datasets.UMFunctionGroup.UM_Q_GROUP_FN_TBLDataTable dt3 = new PTT_Forest.Models.Datasets.UMFunctionGroup.UM_Q_GROUP_FN_TBLDataTable();
        //        UM_Q_GROUP_FN_TBLTableAdapter ta3 = new UM_Q_GROUP_FN_TBLTableAdapter();

        //        object poData3 = new object();
        //        decimal? poStatus3 = -1;
        //        string poStatusMsg3 = string.Empty;

        //        int result3 = ta3.Fill(dt3, null, out poData3, out poStatus3, out poStatusMsg3);

        //        if (poStatus3 == 1)
        //        {
        //            var funcList = new List<SelectListItem>();

        //            foreach (DataRow row in dt3.Rows)
        //            {
        //                string value = row.Field<string>("GFID");
        //                string text = row.Field<string>("NAME");
        //                funcList.Add(new SelectListItem { Value = value, Text = text });
        //            }

        //            umUserGroup.FUNCTIONLIST = funcList;
        //        }
        //        else
        //        {

        //        }

        //        PTT_Forest.Models.Datasets.UMUser.UM_Q_USER_BY_GROUPDataTable dt = new PTT_Forest.Models.Datasets.UMUser.UM_Q_USER_BY_GROUPDataTable();
        //        UM_Q_USER_BY_GROUPTableAdapter ta = new UM_Q_USER_BY_GROUPTableAdapter();

        //        object poData = new object();
        //        decimal? poStatus = -1;
        //        string poStatusMsg = string.Empty;

        //        int result = ta.Fill(dt, null, out poData, out poStatus, out poStatusMsg);

        //        if (poStatus == 1)
        //        {
        //            PTT_Forest.Models.Datasets.UMUser.UM_Q_USER_BY_GROUPDataTable dt2 = new PTT_Forest.Models.Datasets.UMUser.UM_Q_USER_BY_GROUPDataTable();
        //            UM_Q_USER_BY_GROUPTableAdapter ta2 = new UM_Q_USER_BY_GROUPTableAdapter();

        //            object poData2 = new object();
        //            decimal? poStatus2 = -1;
        //            string poStatusMsg2 = string.Empty;

        //            int result2 = ta2.Fill(dt2, id, out poData2, out poStatus2, out poStatusMsg2);

        //            if (poStatus2 == 1)
        //            {
        //                var results = (from table1 in dt.AsEnumerable()
        //                               join table2 in dt2.AsEnumerable() on table1.Field<string>("UID") equals table2.Field<string>("UID")
        //                               into g
        //                               where g.Count() == 0
        //                               select table1);

        //                var allnameList = new List<SelectListItem>();

        //                if (results.Count() != 0)
        //                {
        //                    foreach (DataRow row in results.CopyToDataTable().Rows)
        //                    {
        //                        string value = row.Field<string>("UID").ToString();
        //                        string text = row.Field<string>("NAME");
        //                        allnameList.Add(new SelectListItem { Value = value, Text = text });
        //                    }
        //                }
        //                umUserGroup.ALLNAMELIST = allnameList;


        //                var nameList = new List<SelectListItem>();

        //                foreach (DataRow row in dt2.Rows)
        //                {
        //                    string value = row.Field<string>("UID").ToString();
        //                    string text = row.Field<string>("NAME");
        //                    nameList.Add(new SelectListItem { Value = value, Text = text });
        //                }

        //                umUserGroup.NAMELIST = nameList;
        //            }
        //            else
        //            {

        //            }

        //        }
        //        else if (poStatus == 0)
        //        {
        //            //Fail
        //        }

        //        ViewBag.Title = "แก้ไขกลุ่มผู้ใช้งาน";
        //        return PartialView("Edit", umUserGroup);
        //    }
        //}

        //[HttpPost]
        //public JsonResult Delete(UMUserGroup umUserGroup)
        //{
        //    UM_Q_GROUP_USERTableAdapter ta = new UM_Q_GROUP_USERTableAdapter();

        //    decimal? poStatus = -1;
        //    string poStatusMsg = string.Empty;

        //    object result = ta.UM_D_GROUP_USER(umUserGroup.GUID, out poStatus, out poStatusMsg);

        //    if (poStatus == 1)
        //    {
        //        string title = "ข้อความแจ้งเตือน";
        //        string message = "ลบกลุ่มผู้ใช้งานเรียบร้อย";
        //        return Json(new { success = true, dialog = new { title = title, message = message } });
        //    }
        //    else
        //    {
        //        string title = "เกิดข้อผิดพลาด";
        //        string message = poStatusMsg;
        //        return Json(new { success = false, dialog = new { title = title, message = message } });
        //    }
        //}

        //[HttpPost]
        //public JsonResult Edit(UMUserGroup umUserGroup, string fnList)
        //{
        //    UM_Q_GROUP_USERTableAdapter ta = new UM_Q_GROUP_USERTableAdapter();

        //    decimal? poStatus = -1;
        //    string poStatusMsg = string.Empty;

        //    if (fnList == "")
        //    {
        //        fnList = null;
        //    }
        //    object result = ta.UM_U_GROUP_USER(umUserGroup.GUID, umUserGroup.NAME, umUserGroup.FUNCTION.ToString(), fnList, out poStatus, out poStatusMsg);

        //    if (poStatus == 1)
        //    {
        //        string title = "ข้อความแจ้งเตือน";
        //        string message = "แก้ไขข้อมูล กลุ่มผู้ใช้งาน " + umUserGroup.NAME + " เรียบร้อย";
        //        return Json(new { success = true, dialog = new { title = title, message = message } });
        //    }
        //    else
        //    {
        //        if (poStatusMsg == "duplicate")
        //        {
        //            string title = "เกิดข้อผิดพลาด";
        //            string message = "ไม่สามารถแก้ไขข้อมูล เนื่องจากกลุ่ม " + umUserGroup.NAME + " ซ้ำ";
        //            return Json(new { success = false, dialog = new { title = title, message = message } });
        //        }
        //        else
        //        {
        //            string title = "เกิดข้อผิดพลาด";
        //            string message = poStatusMsg;
        //            return Json(new { success = false, dialog = new { title = title, message = message } });
        //        }
        //    }
        //}
    }
}
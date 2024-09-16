using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TH1_Lab01b.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Bai2ab()
        {
            return View();
        }

        public ActionResult Bai2c()
        {
            ViewBag.Message = "Câu c";

            return View();
        }

        public ActionResult Bai3()
        {
            ViewBag.Message = "Thông tin sinh viên";

            return View();
        }
        public ActionResult Bai4()
        {
            ViewBag.Message = "Xây dựng trang web";

            return View();
        }
        public ActionResult Bai5()
        {
            ViewBag.Message = "Xây dựng trang web";

            return View();
        }

    }
}
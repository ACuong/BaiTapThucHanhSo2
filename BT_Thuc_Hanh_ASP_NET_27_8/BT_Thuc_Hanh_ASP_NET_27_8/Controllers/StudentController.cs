using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT_Thuc_Hanh_ASP_NET_27_8.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Getinfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Getinfo(string ten, string tuoi, string lop)
        {
           
            ViewBag.ten = ten;
            ViewBag.tuoi = tuoi;
            ViewBag.Lop = lop;
            return View();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Neo4jDotNetDemo.Models;
namespace Neo4jDotNetDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        Person ps = new Person();
        public ActionResult Index()
        {
            ps.Id = 12;
            ps.Name = "just test";
            var students = new List<string>
            {
                "A",
                "B",
                "C"
            };

            //string name = "hello world";
            ViewBag.students = students;
            ViewBag["nguoi"] = ps;
            return View(ps);
        }
    }
}
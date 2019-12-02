using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEventCalendar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Adding()
        {
            return View("~/Views/Home/Adding.cshtml");
        }

        public ViewResult Add(Event element)
        {   
            using (MyDatabaseEntities db = new MyDatabaseEntities())
            {
                db.Events.Add(element);
                db.SaveChanges();
            }

            return View("~/Views/Home/Index.cshtml");
        }

        public JsonResult GetEvents()
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var events = dc.Events.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
    }
}
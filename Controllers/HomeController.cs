using FormRegistrator.DAL;
using FormRegistrator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormRegistrator.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db = new ApplicationContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string query = "SELECT RegistrationDate, COUNT(*) AS ClientCount "
              + "FROM Client "
              + "GROUP BY RegistrationDate";

            IEnumerable<RegistrationDateGroup> data = db.Database.SqlQuery<RegistrationDateGroup>(query);

            var clintsList = data.ToList();

            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
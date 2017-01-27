using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Obrazcovo.Controllers
{
    public class HomeController : Controller
    {
        protected UserManager<Models.ApplicationUser> UserManager { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Thread()
        {
            Models.ApplicationDbContext db = new Models.ApplicationDbContext();

            this.UserManager = new UserManager<Models.ApplicationUser>(new UserStore<Models.ApplicationUser>(db));
            var user = UserManager.FindById(User.Identity.GetUserId());

            db.Threads.Add(new Models.Thread() {Name = "Test", Owner = user});
            db.SaveChanges();
            ViewBag.Message = "Thread Added";

            return View();
        }
    }
}
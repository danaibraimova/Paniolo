using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paniolo.Controllers
{
    public class AdminController : Controller
    {
        /*[Authorize(Roles = "Admin, AnotherRole")]*/
        // GET: Admin
        /* public ActionResult Index()
         {
             return View();
         }*/
        [Authorize(Roles = "Admin")]
        public ContentResult AdminContent()
        {
            return Content("this is for admin only");
        }
        public ContentResult Overt()
        {
            return Content("this is not");
        }
    }
}
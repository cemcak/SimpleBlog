using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.AdminArea.Controllers
{
    public class UsersController : Controller
    {
        // GET: AdminArea/Users
        public ActionResult Index()
        {
            return Content("Users");
        }
        public ActionResult Edit()
        {
            return Content("Edit");
        }
        public ActionResult List()
        {
            return Content("List");
        }
    }
}
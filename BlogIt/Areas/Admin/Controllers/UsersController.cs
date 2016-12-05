using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogIt.Infrastructure;

namespace BlogIt.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller   
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
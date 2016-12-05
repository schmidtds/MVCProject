using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogIt.Areas.Admin.ViewModels;
using BlogIt.Infrastructure;
using BlogIt.Models;
using NHibernate.Linq;

namespace BlogIt.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller   
    {
        public ActionResult Index()
        {
            return View(new UsersIndex{Users = Database.Session.Query<User>().ToList()});
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WVCApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index() => View();

        public ActionResult Autenticar()
        {
            return RedirectToAction("Index", "Principal");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WVCApp.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult CambioPassword()
        {
            return View();
        }

        public ActionResult RegistroUsuarioWeb()
        {
            return View();
        }
    }
}
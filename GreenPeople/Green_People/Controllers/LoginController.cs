using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace Green_People.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            if (WebSecurity.Login(login, senha))
            {
                return RedirectToAction("Form", "Produto");
            }
            else
            {
                ModelState.AddModelError("login.Invalido", "Login ou Senha incorretos");
                return View("Index");
            }
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index");
        }
    }
}
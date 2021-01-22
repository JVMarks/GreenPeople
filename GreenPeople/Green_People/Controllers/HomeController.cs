using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green_People.Controllers
{
    //ISTALAR O Entity
    //Install-Package EntityFramework 

    //PARA ABILITAR AS MIGRATIONS
    //enable-migrations
    //add-migration TabelasIniciais
    //update-database

    //instalar mais uma dependencia 
    //Install-Package Ninject.MVC3

    //instalar o simple Mibership é uma biblioteca
    //Install-Package Microsoft.AspNet.WebPages.WebData 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
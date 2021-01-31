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

    //Dentro dessa aplicção usei como referencia o curso de
    //Controle Financeiro ASP.Net MVC 5 
    //Fiz o uso de FrameWorks Entity, Simple Membership para criação dos bancos de dados
    //Realizei o uso da DAO (Faz o mapeamento do banco de dados), Entidades, Migrations, e Models
    //Dentro dos controllers fiz o uso da regra de negocio da aplicação
    //Em Views usei conhecimentos de reciclagem de codigo usando HTML5/CSS3/JAVASCRIPT, alem o uso @model dentro da view
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
    }
}
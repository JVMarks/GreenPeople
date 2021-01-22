using Green_People.DAO;
using Green_People.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green_People.Controllers
{
    public class ProdutoController : Controller
    {
        //codigo da regra de negocio
        // GET: Produto
        //crição de atributo
        private ProdutosDAO produtosDAO;
        public ProdutoController(ProdutosDAO produtosDAO)
        {
            this.produtosDAO = produtosDAO;
        }

        [Authorize]
        public ActionResult Form()
        {
            return View();
        }

        [Authorize]
        public ActionResult Adiciona(Produto produto)
        {
            if (ModelState.IsValid)
            {
                produtosDAO.Adiciona(produto);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", produto);
            }
            //nem todos os valores retornam um valor :/         
        }

        //vizualição da lista 
        public ActionResult Index()
        {
            IList<Produto> produtos = produtosDAO.Lista();
            return View(produtos);
        }
    }
}
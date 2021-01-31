using Green_People.DAO;
using Green_People.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green_People.Controllers
{
    // c# parte 1 if  else, c parte 2 uso de classes de objetos e do this
    //A palavra-chave this refere-se à instância atual da classe e também 
    //é usada como um modificador do primeiro parâmetro de um método de extensão.
    //DENTRO DA CONTROLER FIZ O USO DE CONDIÇÕES COM 
    // IFF E ELSE PARA REALIZAR O CADASTRO DE UM NOVO PRODUTO E VERIFICAÇÃO JUNTO COM
    // ModelState
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
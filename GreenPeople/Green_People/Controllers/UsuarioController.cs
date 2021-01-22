using Green_People.DAO;
using Green_People.Entidades;
using Green_People.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using System.Web.Security;

namespace Green_People.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        private UsuarioDAO usuarioDAO;
        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Adiciona(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    /*
                    Usuario usuario = new Usuario
                    {
                        Nome = model.Nome,
                        CPF = model.CPF,
                        Endereco1 = model.Endereco1,
                        Bairro = model.Bairro,
                        Cidade = model.Cidade,
                        Estado = model.Estado,
                        CEP = model.CEP,
                        Data_de_nacimento = model.Data_de_nacimento,
                        Idade = model.Idade,
                        Sexo = model.Sexo
                    };
                    usuarioDAO.Adiciona(usuario);
                    WebSecurity.CreateAccount(model.Nome, model.Senha);
                    */
                    WebSecurity.CreateUserAndAccount(
                        model.Nome,
                        model.Senha,
                        new
                        {
                            Idade = model.Idade,
                            CPF = model.CPF,
                            Endereco1 = model.Endereco1,
                            Bairro = model.Bairro,
                            Cidade = model.Cidade,
                            Estado = model.Estado,
                            CEP = model.CEP,
                            Data_de_nacimento = model.Data_de_nacimento,
                            Limite_de_cretido = model.Limite_de_cretido,
                            Volume_da_compra = model.Volume_da_compra,
                            Primeira_compra = model.Primeira_compra,
                        }
                        );
                    return RedirectToAction("Form", "Produto");
                }
                catch (MembershipPasswordException e)
                {
                    ModelState.AddModelError("usuario.Invalido", e.Message);
                    return View("Cadastro", model);
                }
            }
            else
            {
                return View("Cadastro", model);
            }

        }
    }
}
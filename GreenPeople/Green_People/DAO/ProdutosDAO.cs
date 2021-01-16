using Green_People.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green_People.DAO
{
    public class ProdutosDAO
    {
        //contexto construtor do entyfremework
        private EstoqueContext context;
        public ProdutosDAO(EstoqueContext context)
        {
            this.context = context;
        }

        public void Adiciona(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        public IList<Produto> Lista()
        {
            return context.Produtos.ToList();
        } 

    }
}
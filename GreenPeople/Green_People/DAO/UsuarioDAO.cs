using Green_People.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green_People.DAO
{
    public class UsuarioDAO
    {
        private EstoqueContext context;
        public UsuarioDAO(EstoqueContext context)
        {
            this.context = context;
        }

        public void Adiciona(Usuario usuario)
        {
            context.usuarios.Add(usuario);
            context.SaveChanges();
        }   
    }
}
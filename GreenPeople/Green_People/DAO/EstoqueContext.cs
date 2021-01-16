using Green_People.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Green_People.DAO
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; } 

        public DbSet<Usuario> usuarios { get; set; }

        //CHAVE ESTRANJEIRA
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //  modelBuilder.Entity<Vendedor>().HasRequired(m => m.Produto);
        //}

        //enable-migrations
        //add-migration TabelasIniciais
        //update-database
    }
}
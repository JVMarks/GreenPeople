using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Green_People.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        //public string codigo_do_produto { get; set; }

        [StringLength(10)]
        public String codigo_do_produto { get; set; }

        public string nome_do_Produto { get; set; }

        public string embalagem { get; set; }

        public string tamanho { get; set; }

        public string sabor { get; set; }

        public float preco { get; set; }
    }
}
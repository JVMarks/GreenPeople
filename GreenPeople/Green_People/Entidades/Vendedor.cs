using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Green_People.Entidades
{
    public class Vendedor
    {

        public int id { get; set; }

        [StringLength(5)]
        public String Matricula { get; set; }

        [Required]
        public string Nome { get; set; }

        public float Percentual_comissao { get; set; }

        public DateTime Data_admissao { get; set; }

        public int De_ferias { get; set; }

        //public Produto Produto { get; set; }
    }
}
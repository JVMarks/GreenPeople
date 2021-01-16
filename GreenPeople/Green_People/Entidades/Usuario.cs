using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Green_People.Entidades
{
    public class Usuario
    {
        public int id { get; set; }

        [Required]
        public string Nome { get; set; }
        
        [StringLength(11)]
        public String CPF { get; set; }

        public string Endereco1 { get; set; }

        public string Endereco2 { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int CEP { get; set; }

        public DateTime Data_de_nacimento { get; set; }

        public int Idade { get; set; }

        public string Sexo { get; set; }

        public float Limite_de_cretido { get; set; }

        public float Volume_da_compra { get; set; }

        public int Primeira_compra { get; set; }

    }
}
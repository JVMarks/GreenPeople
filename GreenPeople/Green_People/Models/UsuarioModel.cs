using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Green_People.Models
{
    public class UsuarioModel
    {
        //Modelo intermediario viewModel 
        // USAMOS QUNADO OS DADOS NÃO SÃO MAPEDOS DE 1 PARA 1 NA VIEW
        // QUANDO A UMA DIFERENÇA DOS DADOS QUE APRESENTAMOS NA VIEW E NO BANCO DE DADOS
        
        // A VALIDAÇÃO É FEITA DENTRO DAS MODELS  

        [Required]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Endereco1 { get; set; }

        public string Endereco2 { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public int CEP { get; set; }

        [Required]
        public DateTime Data_de_nacimento { get; set; }

        [Required]
        public int Idade { get; set; }

        public string Sexo { get; set; }

        [Required]
        public string Senha { get; set; }

        //comparação para verificação de senha
        [Compare("Senha")]
        public string ConfirmarSenha { get;  set; }

        //preciso fazer uma forma para que o usuario comece com 0 de credito 
        [Required]
        public float Limite_de_cretido { get; set; }

        [Required]
        public float Volume_da_compra { get; set; }

        [Required]
        public int Primeira_compra { get; set; }
    }
}
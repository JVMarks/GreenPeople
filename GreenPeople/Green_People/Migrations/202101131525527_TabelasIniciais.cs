namespace Green_People.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codigo_do_produto = c.String(maxLength: 10),
                        nome_do_Produto = c.String(),
                        embalagem = c.String(),
                        tamanho = c.String(),
                        sabor = c.String(),
                        preco = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(maxLength: 11),
                        Endereco1 = c.String(),
                        Endereco2 = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        CEP = c.Int(nullable: false),
                        Data_de_nacimento = c.DateTime(nullable: false),
                        Idade = c.Int(nullable: false),
                        Sexo = c.String(),
                        Limite_de_cretido = c.Single(nullable: false),
                        Volume_da_compra = c.Single(nullable: false),
                        Primeira_compra = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Vendedors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Matricula = c.String(maxLength: 5),
                        Nome = c.String(nullable: false),
                        Percentual_comissao = c.Single(nullable: false),
                        Data_admissao = c.DateTime(nullable: false),
                        De_ferias = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendedors");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Produtoes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using BlueBirdSnowboardingApp.models;

#nullable disable

namespace BlueBirdSnowboardingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisSnowboarding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SnowboardingDbContext();

            context.Snowboard.AddRange(ObterCargaInicialSnowboarding());
            context.SaveChanges();

        }

        private IList<Snowboard> ObterCargaInicialSnowboarding()
        {
            return new List<Snowboard>
           {
                        new Snowboard
                {
                    
                    Nome = "Flyng V - 300",
                    Descricao = "",
                    ImagemUri = "/images/01.jpg",
                    Preco = 450.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now

                },
                         new Snowboard
        {
            
            Nome = "Flyng V - 500",
            Descricao = "",
            ImagemUri = "/images/02.jpg",
            Preco = 650.00,
            EntregaExpressa = true,
            DataCadastro = DateTime.Now

        },
         new Snowboard
        {
            
            Nome = "Ripcord",
            Descricao = "",
            ImagemUri = "/images/03.jpg",
            Preco = 500.00,
            EntregaExpressa = true,
            DataCadastro = DateTime.Now

        },
          new Snowboard
        {
            
            Nome = "Custom LPM",
            Descricao = "",
            ImagemUri = "/images/04.jpg",
            Preco = 450.00,
            EntregaExpressa = true,
            DataCadastro = DateTime.Now

        },
            };
        }
       
    }
}

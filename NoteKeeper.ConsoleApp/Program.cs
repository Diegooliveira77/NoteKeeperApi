using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NoteKeeper.Dominio.ModuloCategoria;
using NoteKeeper.Infra.Orm.Compartilhado;

namespace NoteKeeper.ConsoleApp
{
  internal class Program
  {
    static void Main(string[] args)
    {

      var novaCategoria = new Categoria();
      novaCategoria.Titulo = "Mercado";

      var optionsBuilder = new DbContextOptionsBuilder<NoteKeeperDbContext>();

      IConfiguration configuracao = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json")
         .Build();

      var connectionString = configuracao.GetConnectionString("SqlServer");

      optionsBuilder.UseSqlServer(@"Data Source=(LOCALDB)\MSSQLLOCALDB;Initial Catalog=NoteKeeper;Integrated Security=True");

      var dbContext = new NoteKeeperDbContext(optionsBuilder.Options);

      dbContext.Add(novaCategoria);

      dbContext.SaveChanges();
    }
  }
}

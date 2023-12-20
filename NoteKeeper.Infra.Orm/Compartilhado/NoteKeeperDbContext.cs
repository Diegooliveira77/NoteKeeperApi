using Microsoft.EntityFrameworkCore;
using NoteKeeper.Dominio.Compartilhado;
using NoteKeeper.Dominio.ModuloCategoria;
using NoteKeeper.Dominio.ModuloNota;

namespace NoteKeeper.Infra.Orm.Compartilhado
{
  public class NoteKeeperDbContext : DbContext, IContextoPersistencia
  {
    public NoteKeeperDbContext(DbContextOptions<NoteKeeperDbContext> options) : base(options)
    {

    }

    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Nota> Notas { get; set; }

    public async Task<bool> GravarAsync()
    {
      await SaveChangesAsync();
      return true;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Categoria>();

      modelBuilder.Entity<Nota>();

      base.OnModelCreating(modelBuilder);
    }
  }
}

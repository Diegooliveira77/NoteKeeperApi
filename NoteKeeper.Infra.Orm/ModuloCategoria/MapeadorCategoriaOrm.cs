using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NoteKeeper.Dominio.ModuloCategoria;

namespace NoteKeeper.Infra.Orm.ModuloCategoria
{
    public class MapeadorCategoriaOrm : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("TBCategoria");

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Titulo)
                .IsRequired();

            builder.HasMany(x => x.Notas);
        }
    }
}

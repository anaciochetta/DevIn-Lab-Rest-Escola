using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.DataBase.Mappings
{
    public class NotasMateriaMap : IEntityTypeConfiguration<NotasMateria>
    {
        public void Configure(EntityTypeBuilder<NotasMateria> builder)
        {
            builder.ToTable("NOTAS_MATERIA");

            builder.HasKey(x => x.Id)
                   .HasName("PK_NotasMateriaID");

            builder.Property(x => x.Id)
                    .HasColumnName("ID")
                    .HasColumnType("uniqueidentifier");

            builder.Property(x => x.Nota)
                    .HasColumnName("NOTA")
                    .HasColumnType("int");

            builder
                    .HasOne(x => x.Boletim)
                    .WithMany(x => x.Notas)
                    .HasForeignKey(x => x.BoletimId);

            builder
                    .HasOne(x => x.Materia)
                    .WithMany(x => x.NotasMaterias)
                    .HasForeignKey(x => x.MateriaId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
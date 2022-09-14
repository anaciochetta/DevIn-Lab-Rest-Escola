using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.DataBase.Mappings
{
    public class MateriaMap : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("MATERIAS");

            builder.HasKey(x => x.Id)
                  .HasName("PK_MateriaID");

            builder.Property(x => x.Id)
                   .HasColumnName("ID")
                   .HasColumnType("int");

            builder.Property(x => x.Nome)
                    .HasColumnName("NOME")
                    .HasColumnType("VARCHAR(50)");
        }
    }
}
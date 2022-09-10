using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.DataBase.Mappings
{
    public class BoletimMap : IEntityTypeConfiguration<Boletim>
    {
        public void Configure(EntityTypeBuilder<Boletim> builder)
        {
            builder.ToTable("BOLETIM");

            builder.HasKey(x => x.Id)
                   .HasName("PK_BoletimID");

            builder.Property(x => x.Id)
                    .HasColumnName("ID")
                    .HasColumnType("uniqueidentifier");

            builder.Property(x => x.order_date)
                    .HasColumnName("FINAL_SEMESTRE")
                    .HasColumnType("DATE");

            builder
                    .HasOne(x => x.Aluno)
                    .WithMany(x => x.Boletins)
                    .HasForeignKey(x => x.AlunoId);

            //não tenho certeza
            builder
                    .HasMany(x => x.Notas)
                    .WithOne(x => x.Boletim);
        }
    }
}
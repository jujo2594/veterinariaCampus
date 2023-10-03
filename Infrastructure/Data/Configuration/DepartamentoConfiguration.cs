using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        //Se define el nombre de la tabla
        builder.ToTable("Departamento");

        //Se define la llave primaria como 'Id'
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.NombreDepartamento)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Paises)
        .WithMany(p => p.Departamentos)
        .HasForeignKey(p => p.IdPaisFk);
    }
}

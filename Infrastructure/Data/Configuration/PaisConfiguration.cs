using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        //Se define el nombre de la tabla
        builder.ToTable("Pais");

        //Se define la llave principal
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.NombrePais)
        .IsRequired()
        .HasMaxLength(50);
    }
}

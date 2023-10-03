using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteDireccionConfiguration : IEntityTypeConfiguration<ClienteDireccion>
    {
        public void Configure(EntityTypeBuilder<ClienteDireccion> builder)
        {
            builder.ToTable("ClienteDireccion");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.TipoDeVia)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumeroPri)
            .HasColumnType("int");

            builder.Property(p => p.Letra)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Bis)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.LetraSec)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Cardinal)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumeroSec)
            .HasColumnType("int");

            builder.Property(p => p.LetraTer)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumeroTer)
            .HasColumnType("int");

            builder.Property(p => p.CardinalSec)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Complemento)
            .HasMaxLength(50);

            builder.Property(p => p.CodigoPostal)
            .HasMaxLength(50);

            builder.HasOne(p => p.Clientes)
            .WithOne(p => p.ClientesDirecciones)
            .HasForeignKey<ClienteDireccion>(p => p.IdCiudadFk);

            builder.HasOne(p => p.Ciudades)
            .WithMany(p => p.ClientesDirecciones)
            .HasForeignKey(p => p.IdCiudadFk);
        }
    }
}
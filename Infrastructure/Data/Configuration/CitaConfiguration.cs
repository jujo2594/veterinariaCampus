using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CitaConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder.ToTable("Cita");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Fecha)
            .HasColumnType("date");

            builder.Property(p =>p.Hora)
            .HasColumnType("time");

            builder.HasOne(p => p.Clientes)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.IdClienteFk);

            builder.HasOne(p => p.Mascotas)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.IdMascotaFk);

            builder.HasOne(p => p.Servicios)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.IdServicioFk);
        }
    }
}
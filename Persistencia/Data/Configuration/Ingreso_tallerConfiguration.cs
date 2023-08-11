
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Ingreso_tallerConfiguration : IEntityTypeConfiguration<Ingreso_taller>
{
    public void Configure(EntityTypeBuilder<Ingreso_taller> builder)
    {
        builder.ToTable("Ingresos_taller");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Fecha_ingreso)
        .IsRequired()
        .HasColumnType("dateTime");

        builder.HasOne(p => p.Vehiculo)
        .WithMany(p => p.Ingresos_Taller)
        .HasForeignKey(p => p.Id_vehiculo)
        .IsRequired();

        builder.HasOne(p => p.Servicio_especilizado)
        .WithMany(p => p.Ingresos_Taller)
        .HasForeignKey(p => p.Id_servicioEspecializado)
        .IsRequired();
    }
}

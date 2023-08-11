
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Orden_reparacionConfiguration : IEntityTypeConfiguration<Orden_reparacion>
{
    public void Configure(EntityTypeBuilder<Orden_reparacion> builder)
    {
        builder.ToTable("Orden_reparaciones");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Fecha_salidaEstimada)
        .IsRequired()
        .HasColumnType("dateTime");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(p => p.Ingreso_taller)
        .WithOne(p => p.Orden_reparacion)
        .HasForeignKey<Orden_reparacion>(p => p.Id_ingresoTaller)
        .IsRequired();
    }
}



using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Inspeccion_vehiculoConfiguration : IEntityTypeConfiguration<Inspeccion_vehiculo>
{
    public void Configure(EntityTypeBuilder<Inspeccion_vehiculo> builder)
    {
        builder.ToTable("Inspecciones_vehiculos");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Puerta_F_izquierda)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Puerta_F_derecha)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Puerta_T_izquierda)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Puerta_T_derecha)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Radio_marca)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Radio_estado)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Techo)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Muebles)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Tapetes)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Farola_F_izquierda)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Farola_F_derecha)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Farola_T_izquierda)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Farola_T_derecha)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Rueda_F_izquierda)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Rueda_F_derecha)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Rueda_T_izquierda)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Rueda_T_derecha)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Otros)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Diagnostico_cliente)
        .HasMaxLength(150)
        .IsRequired();

        builder.HasOne(p => p.Ingreso_taller)
        .WithMany(p => p.Inspecciones_Vehiculos)
        .HasForeignKey(p => p.Id_ingresoTaller)
        .IsRequired();

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Inspecciones_vehiculos)
        .HasForeignKey(p => p.Id_empleado)
        .IsRequired();

        
    }
}

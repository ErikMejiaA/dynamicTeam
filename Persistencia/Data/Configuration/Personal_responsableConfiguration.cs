
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Personal_responsableConfiguration : IEntityTypeConfiguration<Personal_responsable>
{
    public void Configure(EntityTypeBuilder<Personal_responsable> builder)
    {
        builder.ToTable("Personal_responsables");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Tiempo_reparacion)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p => p.Diagnostico_taller)
        .HasMaxLength(200)
        .IsRequired();

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Personal_responsables)
        .HasForeignKey(p => p.Id_empleado)
        .IsRequired();

        builder.HasOne(p => p.Ingreso_taller)
        .WithMany(p => p.Personal_responsables)
        .HasForeignKey(p => p.Id_ingresoTaller)
        .IsRequired();
        
    }
}

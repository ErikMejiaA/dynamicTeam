
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Estado_reparacionConfiguration : IEntityTypeConfiguration<Estado_reparacion>
{
    public void Configure(EntityTypeBuilder<Estado_reparacion> builder)
    {
        builder.ToTable("Estado_reparaciones");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Estado)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(p => p.Orden_reparacion)
        .WithMany(p => p.Estado_reparaciones)
        .HasForeignKey(p => p.Id_ordenReparacion)
        .IsRequired();

    }
}

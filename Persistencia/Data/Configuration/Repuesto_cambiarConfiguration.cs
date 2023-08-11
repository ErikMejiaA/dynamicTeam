
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Repuesto_cambiarConfiguration : IEntityTypeConfiguration<Repuesto_cambiar>
{
    public void Configure(EntityTypeBuilder<Repuesto_cambiar> builder)
    {
        builder.ToTable("Repuestos_cambiar");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Estado)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Marca)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p => p.Cantidad)
        .IsRequired();

        builder.Property(p => p.Valor_unitario)
        .IsRequired()
        .HasColumnType("decimal");

        builder.HasOne(p => p.Personal_responsable)
        .WithMany(p => p.Repuestos_cambiar)
        .HasForeignKey(p => p.Id_personalResponsable)
        .IsRequired();

        builder.HasOne(p => p.Orden_reparacion)
        .WithMany(p => p.Repuestos_cambiar)
        .HasForeignKey(p => p.Id_ordenReparacion)
        .IsRequired();

        builder.HasOne(p => p.Producto_sucursal)
        .WithOne(p => p.Repuesto_cambiar)
        .HasForeignKey<Repuesto_cambiar>(p => p.Id_productoSucursal)
        .IsRequired();

        
    }
}

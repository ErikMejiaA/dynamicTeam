
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Producto_sucursalConfiguration : IEntityTypeConfiguration<Producto_sucursal>
{
    public void Configure(EntityTypeBuilder<Producto_sucursal> builder)
    {
        builder.ToTable("Productos_sucursales");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Cantidad)
        .IsRequired();

        builder.Property(p => p.PrecioCompraVU)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.PrecioVentaVU)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.Estado_producto)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Marca)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasOne(p => p.Producto)
        .WithMany(p => p.Productos_sucursales)
        .HasForeignKey(p => p.Id_producto)
        .IsRequired();

        builder.HasOne(p => p.Sucursal)
        .WithMany(p => p.Productos_sucursales)
        .HasForeignKey(p => p.Id_sucursal)
        .IsRequired();
    }
}


using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Producto_proveedorConfiguration : IEntityTypeConfiguration<Producto_proveedor>
{
    public void Configure(EntityTypeBuilder<Producto_proveedor> builder)
    {
        builder.ToTable("Productos_proveedores");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.HasOne(p => p.Producto)
        .WithMany(p => p.Productos_proveedores)
        .HasForeignKey(p => p.Id_producto)
        .IsRequired();

        builder.HasOne(p => p.Proveedor)
        .WithMany(p => p.Productos_proveedores)
        .HasForeignKey(p => p.Id_proveedor)
        .IsRequired();
        
        
    }
}

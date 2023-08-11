
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("Proveedores");

        builder.Property(p => p.IdCodigo)
        .HasMaxLength(10)
        .IsRequired();

        builder.HasIndex(p => p.IdCodigo)
        .IsUnique();

        builder.Property(p => p.Nombre)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Nit_proveedor)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p => p.Email_contacto)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasIndex(p => p.Email_contacto)
        .IsUnique();

        builder.Property(p => p.Estado)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Forma_pago)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasOne(p => p.Sucursal)
        .WithMany(p => p.Proveedores)
        .HasForeignKey(p => p.Id_sucursal)
        .IsRequired();
        
    }
}

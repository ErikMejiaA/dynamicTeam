
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
{
    public void Configure(EntityTypeBuilder<Sucursal> builder)
    {
        builder.ToTable("Sucursales");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Nit_sucursal)
        .HasMaxLength(20)
        .IsRequired();

        builder.HasIndex(p => p.Nit_sucursal)
        .IsUnique();

        builder.Property(p => p.Estado)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Encargado)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=> p.Direccion)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Email)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasIndex(p =>p.Email)
        .IsUnique();

        builder.Property(p => p.Telefono)
        .HasMaxLength(12)
        .IsRequired();

        builder.HasOne(p => p.Empresa_Taller)
        .WithMany(p => p.Sucursales)
        .HasForeignKey(p => p.Id_empresa)
        .IsRequired();

        builder.HasOne(p => p.Ciudad)
        .WithMany(p => p.Sucursales)
        .HasForeignKey(p => p.Id_ciudad)
        .IsRequired();
    }
}

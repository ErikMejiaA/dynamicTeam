
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");

        builder.Property(p => p.IdCodigo)
        .HasMaxLength(10)
        .IsRequired();

        builder.HasIndex(p => p.IdCodigo)
        .IsUnique();

        builder.Property(p => p.Nombre)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Genero)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p => p.Direccion)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Documento)
        .HasMaxLength(15)
        .IsRequired();

        builder.HasIndex(p => p.Documento)
        .IsUnique();

        builder.Property(p => p.Edad)
        .HasMaxLength(3)
        .IsRequired();

        builder.Property(p => p.Email)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.Property(p => p.Estado)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(p => p.Sucursal)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.Id_sucursal)
        .IsRequired();

        
    }
}

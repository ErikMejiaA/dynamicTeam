
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Empresa_tallerConfiguration : IEntityTypeConfiguration<Empresa_taller>
{
    public void Configure(EntityTypeBuilder<Empresa_taller> builder)
    {
        builder.ToTable("Empresas_taller");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Nit_empresa)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasIndex(p => p.Nit_empresa)
        .IsUnique();

        builder.Property(p => p.Direccion)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Email)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.Property(p => p.Representante)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Estado)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Telefono)
        .HasMaxLength(12)
        .IsRequired();

        
    }
}

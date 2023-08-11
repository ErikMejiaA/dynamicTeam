
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EpsConfiguration : IEntityTypeConfiguration<Eps>
{
    public void Configure(EntityTypeBuilder<Eps> builder)
    {
        builder.ToTable("Eps");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre_eps)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Telefono)
        .HasMaxLength(12)
        .IsRequired();
    }
}

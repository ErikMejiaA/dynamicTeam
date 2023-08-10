
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ArlConfiguration : IEntityTypeConfiguration<Arl>
{
    public void Configure(EntityTypeBuilder<Arl> builder)
    {
        builder.ToTable("Arl");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Email)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Telefono)
        .HasMaxLength(12)
        .IsRequired();

    }
}

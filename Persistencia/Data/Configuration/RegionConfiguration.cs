
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Regiones");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasIndex(p => p.Nombre)
        .IsUnique();

        builder.HasOne(p => p.Pais)
        .WithMany(p => p.Regiones)
        .HasForeignKey(p => p.Id_pais)
        .IsRequired();

    }
}


using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Hallazgo_encontradoConfiguration : IEntityTypeConfiguration<Hallazgo_encontrado>
{
    public void Configure(EntityTypeBuilder<Hallazgo_encontrado> builder)
    {
        builder.ToTable("Hallazgos_encontrados");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre_hallazgo)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(p => p.Personal_responsable)
        .WithMany(p => p.Hallazgos_encontrados)
        .HasForeignKey(p => p.Id_personalResponsable)
        .IsRequired();
        
    }
}

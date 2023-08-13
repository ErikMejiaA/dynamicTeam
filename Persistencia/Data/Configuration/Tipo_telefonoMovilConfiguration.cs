
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Tipo_telefonoMovilConfiguration : IEntityTypeConfiguration<Tipo_telefonoMovil>
{
    public void Configure(EntityTypeBuilder<Tipo_telefonoMovil> builder)
    {
        builder.ToTable("Tipos_telefonosMoviles");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre_tipoTelMov)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();

    }
}

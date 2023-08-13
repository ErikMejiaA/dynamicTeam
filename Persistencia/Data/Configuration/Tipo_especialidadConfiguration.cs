
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Tipo_especialidadConfiguration : IEntityTypeConfiguration<Tipo_especialidad>
{
    public void Configure(EntityTypeBuilder<Tipo_especialidad> builder)
    {
        builder.ToTable("Tipos_especialidades");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();

        
    }
}


using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Servicio_especializadoConfiguration : IEntityTypeConfiguration<Servicio_especializado>
{
    public void Configure(EntityTypeBuilder<Servicio_especializado> builder)
    {
        builder.ToTable("Servicios_especializados");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre_servicio)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();
        
    }
}


using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Tipo_empleadoConfiguration : IEntityTypeConfiguration<Tipo_empleado>
{
    public void Configure(EntityTypeBuilder<Tipo_empleado> builder)
    {
        builder.ToTable("Tipos_empleados");

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

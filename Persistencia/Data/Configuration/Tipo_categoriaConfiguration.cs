
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Tipo_categoriaConfiguration : IEntityTypeConfiguration<Tipo_categoria>
{
    public void Configure(EntityTypeBuilder<Tipo_categoria> builder)
    {
        builder.ToTable("Tipos_categorias");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Nombre_categoria)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();
        
    }
}

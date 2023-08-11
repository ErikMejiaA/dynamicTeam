
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");

        builder.Property(p => p.IdCodigo)
        .HasMaxLength(10)
        .IsRequired();

        builder.HasIndex(p => p.IdCodigo)
        .IsUnique();

        builder.Property(p => p.Nombre_producto)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(p => p.Tipo_categoria)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.Id_tipoCategoria)
        .IsRequired();

    }
}

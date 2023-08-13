
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class Tipo_sangreConfiguration : IEntityTypeConfiguration<Tipo_sangre>
{
    public void Configure(EntityTypeBuilder<Tipo_sangre> builder)
    {
        builder.ToTable("Tipos_sangre");

        builder.Property(p => p.Nombre)
        .HasMaxLength(20)
        .IsRequired();
        
    }
}

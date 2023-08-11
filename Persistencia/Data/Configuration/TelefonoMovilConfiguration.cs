
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TelefonoMovilConfiguration : IEntityTypeConfiguration<TelefonoMovil>
{
    public void Configure(EntityTypeBuilder<TelefonoMovil> builder)
    {
        builder.ToTable("TelefonosMoviles");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Numero_telefonoMovil)
        .HasMaxLength(12)
        .IsRequired();

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.TelefonosMoviles)
        .HasForeignKey(p => p.Id_empleado)
        .IsRequired();

        builder.HasOne(p => p.Proveedor)
        .WithMany(p => p.TelefonosMoviles)
        .HasForeignKey(p => p.Id_proveedor)
        .IsRequired();

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.TelefonosMoviles)
        .HasForeignKey(p => p.Id_cliente)
        .IsRequired();

        builder.HasOne(p => p.Tipo_telefonoMovil)
        .WithMany(p => p.TelefonosMoviles)
        .HasForeignKey(p => p.Id_tipoTelefonoMovil)
        .IsRequired();
        
    }
}

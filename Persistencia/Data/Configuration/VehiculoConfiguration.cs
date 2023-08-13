
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
{
    public void Configure(EntityTypeBuilder<Vehiculo> builder)
    {
        builder.ToTable("Vehiculos");

        builder.Property(p => p.IdCodigo)
        .HasMaxLength(10)
        .IsRequired();

        builder.HasIndex(p => p.IdCodigo)
        .IsUnique();

        builder.Property(p => p.Placa)
        .HasMaxLength(20)
        .IsRequired();

        builder.HasIndex(p => p.Placa)
        .IsUnique();

        builder.Property(p => p.Marca)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Modelo)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Color)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Referencia)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasIndex(p => p.Referencia)
        .IsUnique();

        builder.Property(p => p.Motor)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(P => P.Vin)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasIndex(P => P.Vin)
        .IsUnique();

        builder.Property(p => p.Km)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Vehiculos)
        .HasForeignKey(p => p.Id_cliente)
        .IsRequired();
        
    }
}

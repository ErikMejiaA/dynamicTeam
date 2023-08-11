
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
{
    public void Configure(EntityTypeBuilder<Factura> builder)
    {
        builder.ToTable("Facturas");

        builder.Property(p => p.IdCodigo)
        .IsRequired();

        builder.Property(p => p.Forma_pago)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Fecha_salida)
        .IsRequired()
        .HasColumnType("dateTime");
        
        builder.Property(p => p.Valor_total)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.Valor_totalRepuesto)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.Valor_manoObra)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.Valor_totalReparacion)
        .IsRequired()
        .HasColumnType("decimal");

        builder.HasOne(p => p.Orden_reparacion)
        .WithOne(p => p.Factura)
        .HasForeignKey<Factura>(p => p.Id_ordenReparacion);
    }
}

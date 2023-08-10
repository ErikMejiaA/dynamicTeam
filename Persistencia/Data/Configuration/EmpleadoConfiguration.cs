
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleados");

        builder.Property(p => p.IdCodigo)
        .HasMaxLength(10)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Genero)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p => p.Direccion)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Area_trabajo)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.Documento)
        .HasMaxLength(15)
        .IsRequired();

        builder.HasIndex(p => p.Documento)
        .IsUnique();

        builder.Property(p => p.Edad)
        .HasMaxLength(3)
        .IsRequired();

        builder.Property(p => p.Email)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasIndex(p => p.Email)
        .IsUnique();

        builder.HasOne(p => p.Sucursal)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_sucursal)
        .IsRequired();

        builder.HasOne(p => p.Tipo_sangre)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_tipo_sangre)
        .IsRequired();

        builder.HasOne(p => p.Tipo_especialidad)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_tipo_especialidad)
        .IsRequired();

        builder.HasOne(p => p.Eps)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_eps)
        .IsRequired();

        builder.HasOne(p => p.Arl)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_arl)
        .IsRequired();

        builder.HasOne(p => p.Tipo_empleado)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.Id_tipo_empleado)
        .IsRequired();
    }
}

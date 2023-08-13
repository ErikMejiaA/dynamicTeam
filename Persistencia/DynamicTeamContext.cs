
using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class DynamicTeamContext : DbContext
{
    public DynamicTeamContext(DbContextOptions<DynamicTeamContext> options) : base(options)
    {

    }

    //aqui van los DbSet<> de las entidades de la base de datos 
    public DbSet<Arl> ? Arl { get; set; }
    public DbSet<Ciudad> ? Ciudades { get; set; }
    public DbSet<Cliente> ? Clientes { get; set; }
    public DbSet<Empleado> ? Empleados { get; set; }
    public DbSet<Empresa_taller> ? Empresas_taller { get; set; }
    public DbSet<Eps> ? Eps { get; set; }
    public DbSet<Estado_reparacion> ? Estado_reparaciones { get; set; }
    public DbSet<Factura> ? Facturas { get; set; }
    public DbSet<Hallazgo_encontrado> ? Hallazgos_encontrados { get; set; }
    public DbSet<Ingreso_taller> ? Ingresos_taller { get; set; }
    public DbSet<Inspeccion_vehiculo> ? Inspecciones_vehiculos { get; set; }
    public DbSet<Orden_reparacion> ? Orden_reparaciones { get; set; }
    public DbSet<Pais> ? Paises { get; set; }
    public DbSet<Personal_responsable> ? Personal_responsables { get; set; }
    public DbSet<Producto_proveedor> ? Productos_proveedores { get; set; }
    public DbSet<Producto_sucursal> ? Productos_sucursales { get; set; }
    public DbSet<Producto> ? Productos { get; set; }
    public DbSet<Proveedor> ? Proveedores { get; set; }
    public DbSet<Region> ? Regiones { get; set; }
    public DbSet<Repuesto_cambiar> ? Repuestos_cambiar { get; set; }
    public DbSet<Servicio_especializado> ? Servicios_especializados { get; set; }
    public DbSet<Sucursal> ? Sucursales { get; set; }
    public DbSet<TelefonoMovil> ? TelefonosMoviles { get; set; }
    public DbSet<Tipo_categoria> ? Tipos_categorias { get; set; }
    public DbSet<Tipo_empleado> ? Tipos_empleados { get; set; }
    public DbSet<Tipo_especialidad> ? Tipos_especialidades { get; set; }
    public DbSet<Tipo_sangre> ? Tipos_sangre { get; set; }
    public DbSet<Tipo_telefonoMovil> ? Tipos_TelefonosMoviles { get; set; }
    public DbSet<Vehiculo> ? Vehiculos { get; set; }

    //metodo para cargar de forma automatica las entidades y configuraciones de estas en la base de datos creada 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //definimos las llaves primarias campuestas de la entida ProductoPersona. de una relacion de muchos a muchos
        //modelBuilder.Entity<ProductoPersona>().HasKey(p => new {p.IdProducto, p.IdPersona});

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    internal void SaveAsync()
    {
        throw new NotImplementedException();
    }
}

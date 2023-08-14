
namespace Dominio.Interfaces;

public interface IUnitOfWorkInterface
{
    IArlInterface Arl { get; }
    ICiudadInterface Ciudades { get; }
    IClienteInterface Clientes { get; }
    IEmpleadoInterface Empleados { get; }
    IEmpresa_tallerInterface Empresas_taller { get; }
    IEpsInterface Eps { get; }
    IEstado_reparacionInterface Estado_reparaciones { get; }
    IFacturaInterface Facturas { get; }
    IHallazgo_encontradoInterface Hallazgos_encontrados { get; }
    IIngreso_tallerInterface Ingresos_taller { get; }
    IInspeccion_vehiculoInterface Inspecciones_Vehiculos { get; }
    IOrden_reparacionInterface Orden_reparaciones { get; }
    IPaisInterface Paises { get; }
    IPersonal_responsableInterface Personal_responsables { get; }
    IProducto_proveedorInterface Productos_proveedores { get; }
    IProducto_sucursalInterface Producto_sucursal { get; }
    IProductoInterface Productos { get; }
    IProveedorInterface Proveedores { get; }
    IRegionInterface Regiones { get; }
    IRepuesto_cambiarInterface Repuestos_Cambiar { get; }
    IServicio_espesializadoInterfac Servicios_especializados { get; }
    ISucursalInterface Sucursales { get; }
    ITelefonoMovilInterface TelefonosMoviles { get; }
    ITipo_categoriaInterface Tipos_categorias { get; }
    ITipo_empleadoInterface Tipos_empleados { get; }
    ITipo_especialidadInterface Tipos_especialidades { get; }
    ITipo_sangreInterface Tipos_sangre { get; }
    ITipo_telefonoMovilInterface Tipos_telefonosMoviles { get; }
    IVehiculoInterface Vehiculos { get; }

    Task<int> SaveAsync();
        
}

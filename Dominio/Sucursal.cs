

namespace Dominio;

public class Sucursal : BaseEntityA
{
    public string ? Nit_sucursal { get; set; }
    public string ? Estado { get; set; }
    public string ? Encargado { get; set; }
    public string ? Direccion { get; set; }
    public string ? Email { get; set; }
    public string ? Telefono { get; set; }

    //llaves foraneas 
    public string ? Id_empresa { get; set; }
    public string ? Id_ciudad { get; set; }

    //definimos la referencias 
    public Empresa_taller ? Empresa_Taller { get; set; }
    public Ciudad ? Ciudad { get; set; }

    //definimos las ICollection<>
    public ICollection<Empleado> ? Empleados { get; set; }
    public ICollection<Proveedor> ? Proveedores { get; set; }
    public ICollection<Cliente> ? Clientes { get; set; }
    public ICollection<Producto_sucursal> ? Productos_Sucursales { get; set; }
    
        
}

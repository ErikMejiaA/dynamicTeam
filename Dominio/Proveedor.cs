
namespace Dominio;

public class Proveedor : BaseEntityA
{
    public string ? Nit_proveedor { get; set; }
    public string ? Email_contacto  { get; set; }
    public string ? Estado { get; set; }
    public string ? Forma_pago { get; set; }

    //llave foranea 
    public string ? Id_sucursal { get; set; }

    //definimos las ICollection<>
    public ICollection<Producto_proveedor> ? Productos_proveedores { get; set; }
    public ICollection<TelefonoMovil> ? TelefonosMoviles { get; set; }

    //definimos la referencia
    public Sucursal ? Sucursal { get; set; } 
        
}

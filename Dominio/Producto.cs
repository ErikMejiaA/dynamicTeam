
namespace Dominio;

public class Producto : BaseEntityA
{
    public string ? Nombre_producto { get; set; }
    public string ? Descripcion { get; set; }

    //llave foranea 
    public int Id_tipoCategoria { get; set; }

    //definimos la referencia 
    public Tipo_categoria ? Tipo_categoria { get; set; }

    //definimos la ICollection<>
    public ICollection<Producto_sucursal> ? Productos_sucursales { get; set; }
    public ICollection<Producto_proveedor> ? Productos_proveedores { get; set; }
    
}

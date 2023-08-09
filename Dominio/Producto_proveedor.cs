
namespace Dominio;

public class Producto_proveedor : BaseEntityB
{
    //llave foraneas 
    public string ? Id_producto { get; set; }
    public string ? Id_proveedor { get; set; }
    
    //definimos la referencia 
    public Producto ? Producto { get; set; }
    public Proveedor ? Proveedor { get; set; }
        
}

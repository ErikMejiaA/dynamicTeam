
namespace Dominio;

public class Producto_sucursal : BaseEntityB
{
    //llaves foraneas
    public string ? Id_producto { get; set; }
    public string ? Id_sucursal { get; set; }

    public int Cantidad { get; set; }
    public decimal PrecioCompraVU { get; set; }
    public decimal PrecioVentaVU { get; set; } 
    public string ? Estado_producto { get; set; }
    public string ? Marca { get; set; }

    //definimos la referencia 
    public Producto ? Producto { get; set; }
    public Sucursal ? Sucursal { get; set; }
    public Respuesto_cambiar ? Respuesto_cambiar { get; set; }
    
}

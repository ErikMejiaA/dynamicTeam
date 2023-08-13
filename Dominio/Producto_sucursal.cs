
namespace Dominio;

public class Producto_sucursal : BaseEntityB
{
    public int Cantidad { get; set; }
    public decimal PrecioCompraVU { get; set; }
    public decimal PrecioVentaVU { get; set; } 
    public string ? Estado_producto { get; set; }
    public string ? Marca { get; set; }

    //llaves foraneas
    public string ? Id_producto { get; set; }
    public int ? Id_sucursal { get; set; }

    //definimos la referencia 
    public Producto ? Producto { get; set; }
    public Sucursal ? Sucursal { get; set; }
    public Repuesto_cambiar ? Repuesto_cambiar { get; set; }
    
}


namespace Dominio;

public class Repuesto_cambiar : BaseEntityB
{
    public string ? Estado { get; set; }
    public string ? Marca { get; set; }
    public int ? Cantidad { get; set; }
    public decimal Valor_unitario { get; set; }

    //llaves foraneas 
    public int Id_personalResponsable { get; set; }
    public int Id_productoSucursal { get; set; }
    public int Id_ordenReparacion { get; set; }

    //definimos la referencia 
    public Personal_responsable ? Personal_responsable { get; set; }
    public Producto_sucursal ? Producto_sucursal { get; set; }
    public Orden_reparacion ? Orden_reparacion { get; set; }
    
        
}

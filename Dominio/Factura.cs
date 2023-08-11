
namespace Dominio;

public class Factura : BaseEntityB
{
    public string ? Forma_pago { get; set; }
    public DateTime Fecha_salida { get; set; }
    public decimal Valor_total { get; set; }
    public decimal Valor_totalRepuesto { get; set; }
    public decimal Valor_manoObra { get; set; }
    public decimal Valor_totalReparacion { get; set; }

    //llave foranea 
    public int Id_ordenReparacion { get; set; }

    //definimos la referencia 
    public Orden_reparacion ? Orden_reparacion { get; set; }
        
}

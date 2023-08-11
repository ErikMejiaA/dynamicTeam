
namespace Dominio;

public class Orden_reparacion : BaseEntityB
{
    public DateTime Fecha_salidaEstimada { get; set; }
    public string ? Descripcion { get; set; }

    //llave foranea
    public int Id_ingresoTaller { get; set; }

    //definimos la ICollection<>
    public ICollection<Repuesto_cambiar> ? Repuestos_cambiar { get; set; }
    public ICollection<Estado_reparacion> ? Estado_reparaciones { get; set; }

    //definimos la referencia 
    public Ingreso_taller ? Ingreso_taller { get; set; }
    public Factura ? Factura { get; set; }
        
}

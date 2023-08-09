
namespace Dominio;

public class Orden_reparacion : BaseEntityB
{
    //llave foranea
    public int Id_ingresoTaller { get; set; }
    public DateTime Fecha_salidaEstimada { get; set; }
    public string ? Descripcion { get; set; }
        
}

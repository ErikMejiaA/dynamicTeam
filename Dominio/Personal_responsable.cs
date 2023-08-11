
namespace Dominio;

public class Personal_responsable : BaseEntityB
{
    public string ? Tiempo_reparacion { get; set; }
    public string ? Diagnostico_taller { get; set; }

    //llaves foraneas 
    public string ? Id_empleado { get; set; }
    public int Id_ingresoTaller { get; set; }

    //definimos la referencia 
    public Empleado ? Empleado { get; set; }
    public Ingreso_taller ? Ingreso_taller { get; set; }

    //definimos las ICollection<>
    public ICollection<Repuesto_cambiar> ? Repuestos_cambiar { get; set; }
    public ICollection<Hallazgo_encontrado> ? Hallazgos_encontrados { get; set; }
         
}

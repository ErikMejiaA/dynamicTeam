
namespace Dominio;

public class Ingreso_taller : BaseEntityB
{
    public DateTime Fecha_ingreso { get; set; }
    
    //llave foraneas 
    public string ? Id_vehiculo { get; set; }
    public int Id_servicioEspecializado { get; set; }

    //definimos la referencia 
    public Vehiculo ? Vehiculo { get; set; }
    public Servicio_especializado ? Servicios_especilizados { get; set; }
    public Orden_reparacion ? Orden_reparacion { get; set; }

    //definimos la ICollection<>
    public ICollection<Inspeccion_vehiculo> ? Inspecciones_Vehiculos { get; set; }
    public ICollection<Personal_responsable> ? Personal_responsables { get; set; }


        
}

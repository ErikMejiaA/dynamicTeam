
namespace Dominio;

public class Servicio_especializado : BaseEntityB
{
    public string ? Nombre_servicio { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la Icollection<>
    public ICollection<Ingreso_taller> ? Ingresos_Taller { get; set; }
    
}

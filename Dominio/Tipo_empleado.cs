
namespace Dominio;

public class Tipo_empleado : BaseEntityB
{
    public string ? Nombre { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection<>
    public ICollection<Empleado> ? Empleados { get; set; }
        
}

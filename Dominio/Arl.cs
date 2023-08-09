
namespace Dominio;

public class Arl : BaseEntityB
{
    public string ? Email { get; set; }
    public string ? Descripcion { get; set; }
    public string ? Telefono { get; set; } 

    //definimos la ICollection<>
    public ICollection<Empleado> ? Empleados { get; set; }

        
}


namespace Dominio;

public class Tipo_sangre : BaseEntityB
{
    public string ? Nombre { get; set; }
    //definimos la ICollection<>
    public ICollection<Empleado> ? Empleados { get; set; }
       
}


namespace Dominio;

public class Tipo_sangre : BaseEntityB
{
    //definimos la ICollection<>
    public ICollection<Empleado> ? Empleados { get; set; }
       
}

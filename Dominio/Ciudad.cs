
namespace Dominio;

public class Ciudad : BaseEntityA
{
    public string ? Nombre { get; set; }
    //llave foranea
    public string ? Id_region { get; set; }

    //definimos la referencia 
    public Region ? Region { get; set; }

    //definimos la ICollection
    public ICollection<Sucursal> ? Sucursales { get; set; }
    
}

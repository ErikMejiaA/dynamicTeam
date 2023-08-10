
namespace Dominio;

public class Ciudad : BaseEntityB
{
    public string ? Nombre { get; set; }
    //llave foranea
    public int ? Id_region { get; set; }

    //definimos la referencia 
    public Region ? Region { get; set; }

    //definimos la ICollection
    public ICollection<Sucursal> ? Sucursales { get; set; }
    
}

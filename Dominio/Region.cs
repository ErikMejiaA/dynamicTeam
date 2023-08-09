
namespace Dominio;

public class Region : BaseEntityA
{
    public string ? Nombre { get; set; }
    //Llave foranea
    public string ? Id_pais { get; set; }    

    //definimos la referencia 
    public Pais ? Pais { get; set; }

    //Definimos la ICollection 
    public ICollection<Ciudad> ? Ciudades { get; set; }
}

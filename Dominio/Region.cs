
namespace Dominio;

public class Region : BaseEntityA
{
    //Llave foranea
    public string ? Id_pais { get; set; }    

    //definimos la referencia 
    public Pais ? Pais { get; set; }

    //Definimos la ICollection 
    public ICollection<Ciudad> ? Ciudades { get; set; }
}

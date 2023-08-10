
namespace Dominio;

public class Pais : BaseEntityB
{
    public string ? Nombre { get; set; }
    //definimos la IC   ollection     
    public ICollection<Region> ? Regiones { get; set; }
}

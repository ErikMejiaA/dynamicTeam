
namespace Dominio;

public class Pais : BaseEntityA
{
    //definimos la IC   ollection     
    public ICollection<Region> ? Regiones { get; set; }
}

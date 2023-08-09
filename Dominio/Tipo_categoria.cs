
namespace Dominio;

public class Tipo_categoria : BaseEntityB
{
    public string ? Nombre_categoria { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection<>
    public ICollection<Producto> ? Productos { get; set; }
    
        
}

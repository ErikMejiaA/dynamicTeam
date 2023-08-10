
namespace Dominio;

public class Estado_reparacion : BaseEntityB
{
    //llave foranea 
    public int Id_ordenReparacion { get; set; }
    public string ? Estado { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la referncia 
    public Orden_reparacion ? Orden_reparacion { get; set; }
    
        
}

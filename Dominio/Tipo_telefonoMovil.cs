
namespace Dominio;

public class Tipo_telefonoMovil : BaseEntityB
{
    public string ? Nombre_tipoTelMov { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection<>
    public ICollection<TelefonoMovil> ? TelefonosMoviles { get; set; }
    
        
}

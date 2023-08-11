
namespace Dominio;

public class Hallazgo_encontrado : BaseEntityB
{
    public string ? Nombre_hallazgo { get; set; }
    public string ? Descripcion { get; set; }

    //llave foranea 
    public int Id_personalResponsable { get; set; }

    //definimos la referencia 
    public Personal_responsable ? Personal_responsable { get; set; } 
       
}

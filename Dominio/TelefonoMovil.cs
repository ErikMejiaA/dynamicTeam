
namespace Dominio;

public class TelefonoMovil : BaseEntityB
{
    public string ? Numero_telefonoMovil { get; set; }

    //llaves foraneas 
    public string ? Id_empleado { get; set; }
    public string ? Id_proveedor { get; set; }
    public string ? Id_cliente { get; set; }
    public int Id_tipoTelefonoMovil { get; set; }

    //definimos las referencias 
    public Tipo_telefonoMovil ? Tipo_telefonoMovil { get; set; }
    public Empleado ? Empleado { get; set; }
    public Cliente ? Cliente { get; set; }
    public Proveedor ? Proveedor { get; set; }

        
}

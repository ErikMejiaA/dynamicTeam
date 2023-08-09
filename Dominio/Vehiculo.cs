
namespace Dominio;

public class Vehiculo : BaseEntityA
{
    public string ? Placa { get; set; }
    public string ? Marca { get; set; }
    public string ? Modelo { get; set; }
    public string ? Color { get; set; }
    public string ? Referencia { get; set; }
    public string ? Motor { get; set; }
    public string ? Vin { get; set; }
    public string ? Km { get; set; }

    //llave foranea 
    public string ? Id_cliente { get; set; }    

    //definimos una referencia
    public Cliente ? Cliente { get; set; }    

    //definimos la ICollection<>
    public ICollection<Ingreso_taller> ? Ingresos_Taller { get; set; }
    
}

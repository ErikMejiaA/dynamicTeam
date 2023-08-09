
namespace Dominio;

public class Cliente : BaseEntityA
{
    public string ? Nombre { get; set; }
    public string ? Genero { get; set; }
    public string ? Direccion { get; set; }
    public string ? Documento { get; set; }
    public int Edad { get; set; }
    public string ? Email { get; set; }
    public string ? Estado { get; set; }

    //llave foranea 
    public string ? Id_sucursal { get; set; } 

    //definimoa la referencia 
    public Sucursal ? Sucursal { get; set; }


    //definimos las ICollection<>
    public ICollection<Vehiculo> ? Vehiculos { get; set; }
    public ICollection<TelefonoMovil> ? TelefonosMoviles { get; set; }
        
}

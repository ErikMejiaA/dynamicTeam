
namespace Dominio;

public class Empresa_taller : BaseEntityB
{
    public string ? Nombre { get; set; }
    public string ? Nit_empresa { get; set; }
    public string ? Direccion { get; set; }
    public string ? Email { get; set; }
    public string ? Representante { get; set; }
    public string ? Estado { get; set; }
    public string ? Telefono { get; set; }    

    //definimos la ICollection<>
    public ICollection<Sucursal> ? Sucursales { get; set; }
}

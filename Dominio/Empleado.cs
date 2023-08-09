
namespace Dominio;

public class Empleado : BaseEntityA
{
    public string ? Genero { get; set; }
    public string ? Direccion { get; set; }
    public string ? Area_trabajo { get; set; }
    public string ? Documento { get; set; }
    public int Edad { get; set; }
    public string ? Email { get; set; }

    //llaves foraneas 
    public int Id_tipo_sangre { get; set; }
    public string ? Id_sucursal { get; set; }
    public int Id_tipo_especialidad { get; set; }
    public int Id_eps { get; set; }
    public int Id_arl { get; set; }
    public int Id_tipo_empleado { get; set; }

    //definimos la referencias 
    public Tipo_sangre ? Tipo_sangre { get; set; }
    public Tipo_especialidad ? Tipo_especialidad { get; set; }
    public Eps ? Eps { get; set; }
    public Arl ? Arl { get; set; }
    public Tipo_empleado ? Tipo_empleado { get; set; }

    //definimos la ICollection<>
    public ICollection<Inspeccion_vehiculo> ? Inspecciones_Vehiculos { get; set; }
    public ICollection<Telefono_movil> ? Telefonos_Moviles { get; set; }
    public ICollection<Personal_responsable> ? Personal_Responsables { get; set; }
    
        
}

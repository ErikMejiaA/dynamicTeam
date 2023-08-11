
namespace Dominio;

public class Inspeccion_vehiculo : BaseEntityB
{
    public string ? Puerta_F_izquierda { get; set; }
    public string ? Puerta_F_derecha { get; set; }
    public string ? Puerta_T_izquierda { get; set; }
    public string ? Puerta_T_derecha { get; set; }
    public string ? Radio_marca { get; set; }
    public string ? Radio_estado { get; set; }
    public string ? Techo { get; set; }
    public string ? Muebles { get; set; }
    public string ? Tapetes { get; set; }
    public string ? Farola_F_izquierda { get; set; }
    public string ? Farola_F_derecha { get; set; }
    public string ? Farola_T_izquierda { get; set; }
    public string ? Farola_T_derecha { get; set; }
    public string ? Rueda_F_izquierda { get; set; }
    public string ? Rueda_F_derecha { get; set; }
    public string ? Rueda_T_izquierda { get; set; }
    public string ? Rueda_T_derecha { get; set; }
    public string ? Otros { get; set; }
    public string ? Diagnostico_cliente { get; set; }

    //llaves foraneas
    public int Id_ingresoTaller { get; set; }
    public string ? Id_empleado { get; set; }

    //definimos la referencia 
    public Ingreso_taller ? Ingreso_taller { get; set; }
    public Empleado ? Empleado { get; set; }
    
}

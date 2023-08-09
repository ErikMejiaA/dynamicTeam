
using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class BaseEntityA
{
    [Key] //definimos la llave primary
    public string ? IdCodigo { get; set; }
        
}

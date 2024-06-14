namespace OlimpiadasApi.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Competencia
{
    [Key]
    public string Identificador { get; set; }

    [Required]
    public string Modalidad { get; set; }

    [Required]
    public string Categoria { get; set; }

    public List<Actuacion> Actuaciones { get; set; }
    public List<Juez> Jueces { get; set; }
    public List<Competidor> Competidores { get; set; }
}

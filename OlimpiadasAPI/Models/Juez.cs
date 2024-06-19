namespace OlimpiadasApi.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Juez
{
    [Key]
    public int Identificador { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Nacionalidad { get; set; }

    public List<Competencia> Competencias { get; set; }

    public string Usuario { get; set; }
    public string Contraseña { get; set; }
}

namespace OlimpiadasApi.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Competidor
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Sexo { get; set; }

    [Required]
    public string Nacionalidad { get; set; }

    [Required]
    public int Edad { get; set; }

    public List<Actuacion> Actuaciones { get; set; }
    public List<Competencia> Competencias { get; set; }
}

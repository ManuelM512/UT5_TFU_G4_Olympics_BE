namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Kitesurf
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Actuacion")]
    public int ActuacionId { get; set; }
    public Actuacion Actuacion { get; set; }

    public float Tecnica { get; set; }
    public float Dificultad { get; set; }
    public float AlturaAmplitud { get; set; }
    public float Variedad { get; set; }
    public float ImpresionGeneral { get; set; }
}

namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PistaNatacion
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Actuacion")]
    public int ActuacionId { get; set; }
    public Actuacion Actuacion { get; set; }

    public float Tiempo { get; set; }
    public float Dificultad { get; set; }
    public float Tecnica { get; set; }
}

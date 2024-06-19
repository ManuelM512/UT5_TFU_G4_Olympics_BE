namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Actuacion
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [ForeignKey("Competidor")]
    public int CompetidorId { get; set; }
    public Competidor Competidor { get; set; }

    [ForeignKey("Competencia")]
    public string CompetenciaId { get; set; }
    public Competencia Competencia { get; set; }
}

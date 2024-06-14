namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CompetenciaCompetidor
{
    [Key]
    [Column(Order = 1)]
    [ForeignKey("Competencia")]
    public string CompetenciaId { get; set; }
    public Competencia Competencia { get; set; }

    [Key]
    [Column(Order = 2)]
    [ForeignKey("Competidor")]
    public int CompetidorId { get; set; }
    public Competidor Competidor { get; set; }
}

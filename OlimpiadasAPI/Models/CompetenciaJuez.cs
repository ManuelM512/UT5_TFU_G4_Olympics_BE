namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CompetenciaJuez
{
    [Key]
    [Column(Order = 1)]
    [ForeignKey("Competencia")]
    public string CompetenciaId { get; set; }
    public Competencia Competencia { get; set; }

    [Key]
    [Column(Order = 2)]
    [ForeignKey("Juez")]
    public int JuezId { get; set; }
    public Juez Juez { get; set; }
}

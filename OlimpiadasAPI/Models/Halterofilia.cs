namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Halterofilia
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Actuacion")]
    public int ActuacionId { get; set; }
    public Actuacion Actuacion { get; set; }

    public float Arrancada { get; set; }
    public float DosTiempos { get; set; }
    public float Peso { get; set; }
    public string Genero { get; set; }
}

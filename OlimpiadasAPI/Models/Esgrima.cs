namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Esgrima
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Actuacion")]
    public int ActuacionId { get; set; }
    public Actuacion Actuacion { get; set; }

    public float Toque { get; set; }
    public float DerechoAtaque { get; set; }
    public float Prioridad { get; set; }
    public int Asalto { get; set; }
    public int Combate { get; set; }



}

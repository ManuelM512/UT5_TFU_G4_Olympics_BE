namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GimnasiaClavados
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Actuacion")]
    public int ActuacionId { get; set; }
    public Actuacion Actuacion { get; set; }

    public float Dificultad { get; set; }
    public float Ejecucion { get; set; }
}

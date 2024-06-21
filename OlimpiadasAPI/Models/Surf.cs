namespace OlimpiadasApi.Models;

using OlimpiadasApi.Visitors;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Surf : ICompetencia
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Actuacion")]
    public int ActuacionId { get; set; }
    public Actuacion Actuacion { get; set; }

    public float SeleccionOla { get; set; }
    public float Maniobras { get; set; }
    public float AlturaAmplitud { get; set; }
    public float Variedad { get; set; }
    public float PotenciaRadicalidad { get; set; }
    public float Progresion { get; set; }

    public List<float> attributes { get; set; }
    public List<float> Accept(IVisitor<Surf> visitor)
    {
        return visitor.Visit(this);
    }
}

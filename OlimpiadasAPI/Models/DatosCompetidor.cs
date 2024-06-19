namespace OlimpiadasApi.Models;

using System.ComponentModel.DataAnnotations;

public class DatosCompetidor
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Descripcion { get; set; }
}
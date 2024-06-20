using OlimpiadasApi.Visitors;
using OlimpiadasApi.Models;
public class SurfVisitor : IVisitor
{
    public List<float> Visit(Surf surf)
    {
        var attributes = new List<float>
        {
            surf.SeleccionOla,
            surf.Maniobras,
            surf.AlturaAmplitud,
            surf.Variedad,
            surf.PotenciaRadicalidad,
            surf.Progresion
        };

        surf.attributes = attributes;

        return attributes;
    }
}

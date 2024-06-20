using OlimpiadasApi.Visitors;
using OlimpiadasApi.Models;
public class CalcularPuntajeVisitor : IVisitor<ICompetencia>
{
    public float ponderadosVisit(ICompetencia competencia)
    {
        float result = 0;
        for (int i = 0; i < competencia.attributes.Count; i++)
        {

        }
        return result;
    }


}
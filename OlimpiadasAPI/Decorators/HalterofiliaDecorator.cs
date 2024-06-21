using OlimpiadasApi.Decorators;
using OlimpiadasApi.Models;
using OlimpiadasApi.Visitors;

public class HalterofiliaDecorator : PointsDecorator<Halterofilia>
{
    public List<float> attributes { get; set; }
    public Halterofilia wrappedCompetition { get; set; }
    public List<float> rubric { get; set; }

    public void visit(IVisitor visitor)
    {
        visitor.VisitHalterofilia(this);
    }

    public void PassToAttributes()
    {
        attributes.Add(wrappedCompetition.Arrancada);
        attributes.Add(wrappedCompetition.DosTiempos);
        attributes.Add(wrappedCompetition.Peso);
        // Faltaría aca la rúbrica
    }
}
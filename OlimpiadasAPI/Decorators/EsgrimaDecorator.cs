using OlimpiadasApi.Decorators;
using OlimpiadasApi.Models;
using OlimpiadasApi.Visitors;

public class EsgrimaDecorator : PointsDecorator<Esgrima>
{
    public List<float> attributes { get; set; }
    public Esgrima wrappedCompetition { get; set; }
    public List<float> rubric { get; set; }

    public void visit(IVisitor visitor)
    {
        visitor.VisitEsgrima(this);
    }

    public void PassToAttributes()
    {
        attributes.AddRange(wrappedCompetition.GetType()
            .GetProperties()
            .Select(prop => (float)prop.GetValue(wrappedCompetition))
            .ToList());

        rubric = new List<float>();
        // Faltaría inicializar la rubrica con valores 
    }
}
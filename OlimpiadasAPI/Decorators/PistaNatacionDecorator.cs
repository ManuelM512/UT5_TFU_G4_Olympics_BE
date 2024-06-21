using OlimpiadasApi.Models;
using OlimpiadasApi.Visitors;

namespace OlimpiadasApi.Decorators;
public class PistaNatacionDecorator : PointsDecorator<PistaNatacion>
{
    public List<float> attributes { get; set; }
    public PistaNatacion wrappedCompetition { get; set; }
    public List<float> rubric { get; set; }

    public void visit(IVisitor visitor)
    {
    }

    public void PassToAttributes()
    {

    }
}
using OlimpiadasApi.Decorators;
using OlimpiadasApi.Models;
using OlimpiadasApi.Visitors;

public class SurfDecorator : PointsDecorator<Surf>
{
    public List<float> attributes { get; set; }
    public Surf wrappedCompetition { get; set; }
    public List<float> rubric { get; set; }

    public void visit(IVisitor visitor)
    {
    }

    public void PassToAttributes()
    {

    }
}
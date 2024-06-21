using OlimpiadasApi.Models;
using OlimpiadasApi.Visitors;
namespace OlimpiadasApi.Decorators;


public interface PointsDecorator<T> : IPointsDecorator
{
    public T wrappedCompetition { get; set; }
    public List<float> attributes { get; set; }
    public List<float> rubric { get; set; }
    public void PassToAttributes();

    public void visit(IVisitor visitor);

}
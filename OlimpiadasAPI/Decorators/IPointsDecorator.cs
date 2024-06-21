using OlimpiadasApi.Models;
using OlimpiadasApi.Visitors;
public interface IPointsDecorator : ICompetencia
{
    public List<float> attributes { get; set; }
    public List<float> rubric { get; set; }

    public void PassToAttributes();
    public void visit(IVisitor visitor);
}

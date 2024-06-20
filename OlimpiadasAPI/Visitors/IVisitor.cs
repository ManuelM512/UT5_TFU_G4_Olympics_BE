using OlimpiadasApi.Models;

namespace OlimpiadasApi.Visitors;

public interface IVisitor
{
    List<float> Visit(ICompetencia icompetencia);
}

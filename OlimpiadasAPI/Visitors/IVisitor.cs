using OlimpiadasApi.Models;
using OlimpiadasApi.Decorators;

namespace OlimpiadasApi.Visitors;

public interface IVisitor
{
    float VisitSurf(SurfDecorator surf);
    float VisitPista(PistaNatacionDecorator pistaNatacion);
    string VisitEsgrima(EsgrimaDecorator esgrima);
    double VisitHalterofilia(HalterofiliaDecorator halterofilia);


}

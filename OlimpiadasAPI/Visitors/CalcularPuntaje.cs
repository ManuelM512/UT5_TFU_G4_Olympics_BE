using OlimpiadasApi.Visitors;
using OlimpiadasApi.Models;
using OlimpiadasApi.Decorators;

public class CalcularPuntajeVisitor : IVisitor
{
    public string VisitEsgrima(EsgrimaDecorator esgrima)
    {
        return competitionBased(esgrima);
    }

    public double VisitHalterofilia(HalterofiliaDecorator halterofilia)
    {
        Halterofilia competition = halterofilia.wrappedCompetition;
        double bodyWeight = competition.Peso;
        double liftWeight = competition.DosTiempos + competition.Arrancada;
        bool isMale = competition.Genero == "M";


        return SinclairCalculator.CalculateSinclair(bodyWeight, liftWeight, isMale);
    }

    public float VisitPista(PistaNatacionDecorator pistaNatacion)
    {
        // Aunque parezca raro, con un poco de ingenio en la rúbrica, podría tomarse de la misma forma
        // Ponderas el tiempo total, le sumas / restas en base a las consideraciones que se puedan hacer
        // listo, devolves tiempo total final!
        return ponderar(pistaNatacion);
    }

    public float VisitSurf(SurfDecorator surf)
    {
        return ponderar(surf);
    }

    private float ponderar(IPointsDecorator competencia)
    {
        float result = 0;
        List<float> attributes = competencia.attributes;
        List<float> rubric = competencia.rubric;

        for (int i = 0; i < attributes.Count; i++)
        {
            result += attributes[i] * rubric[i];
        }
        return result;
    }

    private string competitionBased(IPointsDecorator competencia)
    {
        // Lógica para elegir ganador, y lo devolvería
        string winner = "";
        return winner;
    }


}
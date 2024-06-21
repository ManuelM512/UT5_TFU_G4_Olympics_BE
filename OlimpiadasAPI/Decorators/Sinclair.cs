public class SinclairCalculator
{
    // Sinclair coefficients for men and women, updated for the current period
    // These coefficients need to be updated based on the current period's official values.
    private const double A_Men = 0.794358141;
    private const double B_Men = 174.393;
    private const double A_Women = 0.897260740;
    private const double B_Women = 148.026;
    private const double MaxWeight_Men = 198.0; // Maximum competition weight for men (could be updated)
    private const double MaxWeight_Women = 132.5; // Maximum competition weight for women (could be updated)

    public static double CalculateSinclair(double bodyWeight, double liftWeight, bool isMale)
    {
        double coefficientA = isMale ? A_Men : A_Women;
        double coefficientB = isMale ? B_Men : B_Women;
        double maxWeight = isMale ? MaxWeight_Men : MaxWeight_Women;

        // Calculate the Sinclair coefficient
        double sinclairCoefficient;
        if (bodyWeight <= maxWeight)
        {
            sinclairCoefficient = Math.Exp(-coefficientA * Math.Pow(Math.Log(bodyWeight / coefficientB), 2));
        }
        else
        {
            sinclairCoefficient = 1.0; // For body weights over the maximum weight, the coefficient is 1
        }

        // Calculate the Sinclair total
        double sinclairTotal = liftWeight * sinclairCoefficient;
        return sinclairTotal;
    }
}
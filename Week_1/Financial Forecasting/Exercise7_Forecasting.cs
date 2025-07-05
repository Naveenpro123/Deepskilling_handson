using System;

class Forecasting {
    static double PredictGrowth(double current, double rate, int years) {
        if (years == 0) return current;
        return PredictGrowth(current * (1 + rate), rate, years - 1);
    }

    static double PredictGrowthIterative(double current, double rate, int years) {
        for (int i = 0; i < years; i++) {
            current *= (1 + rate);
        }
        return current;
    }

    static void Main() {
        double recursiveValue = PredictGrowth(1000, 0.10, 3);
        double iterativeValue = PredictGrowthIterative(1000, 0.10, 3);

        Console.WriteLine("Recursive Prediction after 3 years: " + recursiveValue);
        Console.WriteLine("Iterative Prediction after 3 years: " + iterativeValue);
    }
}

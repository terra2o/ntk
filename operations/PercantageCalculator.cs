namespace NumberToolkit.Operations
{
    public static class PercantageCalculator
    {
        public static double Calculate(double number, int percent)
        {
            return number * (percent / 100.0);
        }
    }
}
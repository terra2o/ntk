namespace NumberToolkit.Operations
{
    public static class PercantageCalculator
    {
        public static decimal Calculate(decimal number, decimal percent)
        {
            return number * (percent / 100m);
        }
    }
}
// This project is licensed under GPL-3.0 OR later
// This project is made by terra2o for the purpose of practice

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using NumberToolkit.Operations;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string input;
        if (args.Length > 0)
        {
            input = args[0];
        }
        else
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
        }

        input = input.Replace(',', '.');

        if (!double.TryParse(input, 
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out double number))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        BigInteger big = BigInteger.Parse(input);
        decimal decNumber = (decimal)number;

        Console.WriteLine($"Reverse: {Reverser.Reverse(input)}");
        Console.WriteLine("Every digit: " + DigitOperations.EveryDigit(number));
        Console.WriteLine($"Sum Digits:  {DigitOperations.Sum(input)}");
        Console.WriteLine($"Difference of digits: {DigitOperations.Difference(input)}");
        Console.WriteLine($"Square: {SquareAndCube.Square(decNumber)}");
        Console.WriteLine($"Cube: {BigInteger.Pow(big, 3)}");
        Console.WriteLine($"Factors: {string.Join(", ", Factorization.GetFactors((long)number))}");
        Console.WriteLine($"Is prime: {Factorization.CheckPrime((long)number)}");
        Console.WriteLine($"Prime factors: {string.Join(", ", Factorization.PrimeFactorization((long)number))}");

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"%{i}: {PercantageCalculator.Calculate(decNumber, i)}");
        }
    }
}
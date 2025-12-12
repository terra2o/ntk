// This project is licensed under GPL-3.0 OR later
// This project is made by terra2o for the purpose of practice

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using NumberToolkit.Operations;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        input = input?.Replace('.', ',');

        if (!double.TryParse(input, 
        NumberStyles.Any,
        CultureInfo.InvariantCulture,
        out double number))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        Console.WriteLine($"Reverse: {Reverser.Reverse(input)}");
        Console.WriteLine("Every digit: " + DigitOperations.EveryDigit(number));
        Console.WriteLine($"Sum Digits:  {DigitOperations.Sum(input)}");
        Console.WriteLine($"Difference of digits: {DigitOperations.Difference(input)}");
        Console.WriteLine($"Square: {SquareAndCube.Square(number)}");
        Console.WriteLine($"Cube: {SquareAndCube.Cube(number)}");
        Console.WriteLine($"Factors: {string.Join(", ", Factorization.GetFactors((long)number))}");
        Console.WriteLine($"Is prime: {Factorization.CheckPrime((int)number)}");
        Console.WriteLine($"Prime factors: {string.Join(", ", Factorization.PrimeFactorization((long)number))}");

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"%{i}: {PercantageCalculator.Calculate(number, i)}");
        }
    }
}
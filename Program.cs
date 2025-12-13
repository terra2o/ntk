// This project is licensed under GPL-3.0 OR later
// This project is made by terra2o for the purpose of practice

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using NumberToolkit.Operations;
using System.Numerics;
using Spectre.Console;

class Program
{
    static void Main(string[] args)
    {
        var infoTable = new Table()
            .Border(TableBorder.Rounded)
            .Title("[yellow]Number Information[/]")
            .AddColumn("Operation")
            .AddColumn("Result");

        string input;
        if (args.Length > 0)
        {
            input = args[0];
        }
        else
        {
            input = AnsiConsole.Ask<string>("[green]Enter a number:[/]");
        }

        input = input.Replace(',', '.');

        if (!double.TryParse(input, 
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out double number))
        {
            AnsiConsole.Markup("[red]Invalid number. [/]");
            return;
        }

        BigInteger big = BigInteger.Parse(input);
        decimal decNumber = (decimal)number;

        infoTable.AddRow("Reverse", Reverser.Reverse(input));
        infoTable.AddRow("Every digit", DigitOperations.EveryDigit(number).ToString());
        infoTable.AddRow("Sum digits", DigitOperations.Sum(input).ToString());
        infoTable.AddRow("Difference of digits", DigitOperations.Difference(input).ToString());
        infoTable.AddRow("Square", SquareAndCube.Square(decNumber).ToString());
        infoTable.AddRow("Cube", BigInteger.Pow(big, 3).ToString());
        infoTable.AddRow("Is prime", Factorization.CheckPrime((long)number).ToString());
        AnsiConsole.Write(infoTable);

        // --------------------
        // Factors
        // --------------------
        var factorsTable = new Table()
            .Border(TableBorder.Rounded)
            .Title("[yellow]Factors[/]")
            .AddColumn("Factor");

        foreach (var factor in Factorization.GetFactors((long)number))
        {
            factorsTable.AddRow(factor.ToString());
        }

        // --------------------
        // Prime Factors
        // --------------------  
        var primeFactorsTable = new Table()
            .Border(TableBorder.Rounded)
            .Title("[yellow]Prime Factors[/]")
            .AddColumn("Prime");

        foreach (var pf in Factorization.PrimeFactorization((long)number))
        {
            primeFactorsTable.AddRow(pf.ToString());
        }

        // --------------------
        // Percantages
        // --------------------        
        var grid = new Grid();

        for (int i = 0; i <= 6; i++)
        {
            grid.AddColumn();
        }

        for (int i = 0; i < 100; i += 6)
        {
            grid.AddRow(
                $"%{i}: {PercantageCalculator.Calculate(decNumber, i)}",
                $"%{i+1}: {PercantageCalculator.Calculate(decNumber, i+1)}",
                $"%{i+2}: {PercantageCalculator.Calculate(decNumber, i+2)}",
                $"%{i+3}: {PercantageCalculator.Calculate(decNumber, i+3)}",
                $"%{i+4}: {PercantageCalculator.Calculate(decNumber, i+4)}",
                $"%{i+5}: {PercantageCalculator.Calculate(decNumber, i+5)}"
            );
        }
        var percentPanel = new Panel(grid)
        .Header("[yellow]Percentages[/]")
        .Border(BoxBorder.Rounded);

        /*  --------------------
            factorsTable,
            primeFactorsTable,
            grid
            TOGETHER IN COLUMNS
            --------------------
        */
        var layout = new Columns(
            factorsTable,
            primeFactorsTable,
            percentPanel
        )
        {
            Expand = true
        };

        AnsiConsole.Write(layout);
    }
}
using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using Spectre.Console;

namespace KopfRechnen;
public class GenerateRechnung
{
    public static void pluscalculation(int difficulty)
    {
        var random = new Random();
        int numberOne = random.Next(1, 100);
        int numberTwo = random.Next(1, 100);

        switch (difficulty)
        {
            case 1:
                numberOne += random.Next(50, 200);
                numberTwo += random.Next(50, 200);
                break;
            
            case 2:
                numberOne += random.Next(200, 500);
                numberTwo += random.Next(200, 500);
                break;
            
        }

        int result = numberOne + numberTwo;

        int userInput = 0;

        
        
        AnsiConsole.MarkupLine("Calculate This");
        AnsiConsole.MarkupLine($"{numberOne} + {numberTwo} = ?");

        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput != result)
        {
            AnsiConsole.MarkupLine("Thats Wrong, Try Again!");
        }
        
        
        
    }

    public static void minuscalculation(int difficulty)
    {
        var random = new Random();
        int numberOne = random.Next(1, 100);
        int numberTwo = random.Next(1, 100);

        switch (difficulty)
        {
            case 1:
                numberOne += random.Next(50, 200);
                numberTwo += random.Next(50, 200);
                break;
            
            case 2:
                numberOne += random.Next(200, 500);
                numberTwo += random.Next(200, 500);
                break;
        }

        int result = numberOne - numberTwo;
        
        int userInput = 0;
        
        
        AnsiConsole.MarkupLine("Calculate This");
        AnsiConsole.MarkupLine($"{numberOne} - {numberTwo} = ?");

        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput != result)
        {
            AnsiConsole.MarkupLine("That's Wrong, Try Again!");
        }
        
    }

    public static void multiplicationcalculation(int difficulty)
    {
        var random = new Random();
        int numberOne = random.Next(1, 30);
        int numberTwo = random.Next(1, 30);

        switch (difficulty)
        {
            case 1:
                numberOne += random.Next(10, 30);
                numberTwo += random.Next(10, 30);
                break;
            
            case 2:
                numberOne += random.Next(10, 50);
                numberTwo += random.Next(10, 50);
                break;
        }
        
        int result = numberOne * numberTwo;
        
        int userInput = 0;
        
        
        AnsiConsole.MarkupLine("Calculate This");
        AnsiConsole.MarkupLine($"{numberOne} * {numberTwo} = ?");

        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput != result)
        {
            AnsiConsole.MarkupLine("That's Wrong, Try Again!");
        }
    }

    public static void dividedcalculation(int difficulty)
    {
        var random = new Random();
        double numberOne = random.Next(10,50 );
        double numberTwo = random.Next(1, 10);

        switch (difficulty)
        {
            case 1:
                numberOne += random.Next(10, 30);
                numberTwo += random.Next(1, 10);
                break;
            
            case 2:
                numberOne += random.Next(10, 50);
                numberTwo += random.Next(10, 50);
                break;
        }
        
        double result = numberOne / numberTwo;
        result = Math.Round(result, 2);
        
        double userInput = 0;
        
        
        AnsiConsole.MarkupLine("Calculate This, round upto two decimal numbers");
        AnsiConsole.MarkupLine($"{numberOne} / {numberTwo} = ?");

        while (!double.TryParse(Console.ReadLine(), out userInput) || userInput != result)
        {
            AnsiConsole.MarkupLine("That's Wrong, Try Again!");
        }
    }

    public static void GiveCalculation(int difficulty, List<int> calculationTypList)
    {
        var random = new Random();

        int calculationTyp = calculationTypList[random.Next(0, calculationTypList.Count)];

        switch (calculationTyp)
        {
            case 0:
                pluscalculation(difficulty);
                break;
            case 1:
                minuscalculation(difficulty);
                break;
            case 2:
                multiplicationcalculation(difficulty);
                break;
            case 3:
                dividedcalculation(difficulty);
                break;
        }
    }
}

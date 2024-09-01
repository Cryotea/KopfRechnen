// See https://aka.ms/new-console-template for more information

using KopfRechnen;
using Spectre.Console;

AnsiConsole.MarkupLine("Welcome to KopfRechnen!");

var user = new User();

var startselection = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Select the difficulty level")
        .PageSize(10)
        .AddChoices(new[] {
            "Start", "Settings", "High score",
        }));

user.SetUserDifficulty();

user.SetUserCalculationType();


AnsiConsole.MarkupLine("press any button to start!");
Console.ReadLine();
while (true)
{
    GenerateRechnung.GiveCalculation(user.UserDifficulty,user.CalculationTypes);
}

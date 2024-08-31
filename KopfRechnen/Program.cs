// See https://aka.ms/new-console-template for more information

using KopfRechnen;
using Spectre.Console;

AnsiConsole.MarkupLine("Welcome to KopfRechnen!");
AnsiConsole.MarkupLine("press any button to start!");
Console.ReadLine();
while (true)
{
    GenerateRechnung.GiveCalculation(0,0);
}

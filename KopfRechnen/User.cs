using Spectre.Console;

namespace KopfRechnen;

public class User
{
    public int UserDifficulty { get; set; }

    public List<int> CalculationTypes = new List<int>();
    



    public void SetUserDifficulty()
    {
        
        var difficultySelection =AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select the difficulty level")
                .PageSize(10)
                .AddChoices(new[] {
                    "Easy", "Medium", "Hard",
                }));

        switch (difficultySelection)
        {
            case "Easy":
                UserDifficulty = 0;
                break;
            case "Medium":
                UserDifficulty = 1;
                break;
            case "Hard":
                UserDifficulty = 2;
                break;
        }
    }

    public void SetUserCalculationType()
    {
        CalculationTypes = AnsiConsole.Prompt(
            new MultiSelectionPrompt<(string, int)>()
                {
                    Converter = a => a.Item1
                }
                .Title("What types of Calculations do you want to do?")
                .PageSize(10)
                .InstructionsText(
                    "[grey](Press [blue]<space>[/] to toggle a Calculation typ, " + 
                    "[green]<enter>[/] to accept)[/]")
                .AddChoices(new[] {
                    ("Plus", 0), ("Minus", 1), ("multiplication", 2),
                    ("division", 3),
                })).Select(x => x.Item2).ToList();
        
        
            
        
    }
}
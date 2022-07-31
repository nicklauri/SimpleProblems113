namespace Exercises;

public partial class Program
{
    private List<MenuItem> actions;
    private string[] args;

    public static void Main(string[] args)
    {
        new Program(args).Run();
    }

    public Program(string[] args)
    {
        this.args = args;

        // Initialize list of actions, easy to create a menu.
        actions = InitMenuItems();
    }

    public void Run()
    {
        if (args.Length > 0)
        {
            if (int.TryParse(args[0], out var programId))
            {
                RunProgram(programId);
            }
            else
            {
                Console.WriteLine($"Invalid program ID: {programId}, expect from 1 to {actions.Count}");
            }
        }
        else
        {
            RunWithStdin();
        }
    }

    public void RunWithStdin()
    {
        Console.WriteLine("Please select one of the following program:");
        DisplayMenu();

        var idx = ReadIntFromStdin("Your choice: ");
        if (idx is not null)
        {
            RunProgram(idx.Value);
        }
    }

    private void RunProgram(int programId)
    {
        var minChoice = 1;
        var maxChoice = actions.Count;
        if (programId < minChoice || programId > maxChoice)
        {
            Console.WriteLine($"Your input is invalid, expect from {minChoice} to {maxChoice}, got: {programId}");
            return;
        }

        var action = actions[programId - 1];
        Console.WriteLine($"Calculate: {action.Title}");
        action.Action();
    }

    private void DisplayMenu()
    {
        var iter = actions.Select((action, i) => (Idx: i, action.Title));
        foreach (var (idx, title) in iter)
        {
            Console.WriteLine($"{idx + 1,05}: {title}");
        }
    }

    protected class MenuItem
    {
        public string Title { get; init; }
        public Action Action { get; init; }

        public MenuItem(string title, Action action)
        {
            Title = title;
            Action = action;
        }
    }
}

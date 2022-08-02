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
        var program = actions.FirstOrDefault(action => action.Idx == programId);
        if (program is null)
        {
            Console.WriteLine($"Your input is invalid, programId={programId} is not existed.");
            return;
        }

        Console.WriteLine($"Calculate: {program.Title}");
        program.Action();
    }

    private void DisplayMenu()
    {
        foreach (var program in actions)
        {
            Console.WriteLine($"{program.Idx,05}: {program.Title}");
        }
    }

    protected class MenuItem
    {
        public int? Idx { get; set; }
        public string Title { get; init; }
        public Action Action { get; init; }

        public MenuItem(string title, Action action, int? idx = null)
        {
            Title = title;
            Action = action;
            Idx = idx;
        }
    }
}

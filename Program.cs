
namespace BaiTap;

public partial class Program
{
    private List<MenuItem> actions;

    public static void Main(string[] args)
    {
        var program = new Program();
        program.Run();
    }

    public Program()
    {
        // Initialize list of actions, easy to create a menu.
        actions = InitMenuItems();
    }

    public void Run()
    {
        Console.WriteLine("Please select one of the following program:");
        DisplayMenu();

        var minChoice = 1;
        var maxChoice = actions.Count;

        var idx = ReadIntFromStdin("Your choice: ");
        if (idx is null)
        {
            return;
        }

        if (idx < minChoice || idx > maxChoice)
        {
            Console.WriteLine($"Your input is invalid, expect from {minChoice} to {maxChoice}, got: {idx}");
            return;
        }

        var programId = idx.Value - 1;
        var action = actions[programId];
        Console.WriteLine($"Calculate: {action.Title}");
        action.Action();
    }

    public void DisplayMenu()
    {
        var iter = actions.Select((action, i) => (Idx: i, action.Title));
        foreach (var (idx, title) in iter)
        {
            Console.WriteLine($"{idx + 1,05}: {title}");
        }
    }

    public class MenuItem
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

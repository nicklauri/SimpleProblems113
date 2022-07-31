namespace Exercises;

public partial class Program
{
    ///<summary>
    /// Read an integer from stdin and return. <br/>
    /// Return null if user inputs invalid number or the number is less than mustGreaterOrEqual (mustGreaterOrEqual is not null).
    ///</summary>
    public static int? ReadIntFromStdin(string prompt, int? mustGreaterOrEqual = null)
    {
        Console.Write(prompt);

        var line = Console.ReadLine();

        if (int.TryParse(line, out var number))
        {
            if (mustGreaterOrEqual is not null && number < mustGreaterOrEqual)
            {
                Console.WriteLine($"Input is required to be greater than {mustGreaterOrEqual} (your input: {number})");
                return null;
            }

            return number;
        }

        Console.WriteLine($"Expect an integer, found: \"{line}\"");
        return null;
    }
}

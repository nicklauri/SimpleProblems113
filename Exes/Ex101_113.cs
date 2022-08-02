namespace Exercises;

public partial class Program
{
    public void Ex101() { }
    public void Ex102() { }
    public void Ex103() { }
    public void Ex104() { }
    public void Ex105() { }
    public void Ex106() { }
    public void Ex107() { }
    public void Ex108() { }
    public void Ex109() { }

    public void Ex110()
    {
        var totalCases = 0;
        for (var note1k = 0; note1k <= 200; ++note1k)
        {
            for (var note2k = 0; note2k <= 100; ++note2k)
            {
                var note5k = (200 - note1k - 2 * note2k) / 5.0;
                if (note5k >= 0 && note5k % 1 == 0)
                {
                    // Alternative method to check if double is an integer: Math.Abs(note5k % 1) <= (Double.Epsilon * 100)
                    Console.WriteLine($"200k == {note1k,3} * 1k + {note2k,3} * 2k + {note5k,2} * 5k");
                    totalCases += 1;
                }
            }
        }

        Console.WriteLine($"Total possible cases: {totalCases}");
    }

    public void Ex111() { }
    public void Ex112() { }
    public void Ex113() { }
}

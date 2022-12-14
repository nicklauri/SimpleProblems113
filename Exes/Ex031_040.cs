namespace Exercises;

public partial class Program
{
    public void Ex031()
    {
        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        var nIsPrime = false;

        if (n == 2 || n == 3)
        {
            nIsPrime = true;
        }
        else
        {
            // number i will be only an odd number, so we don't have to check if n % 2 == 0.
            for (var i = 3; i < n; i += 2)
            {
                if (n % i == 0)
                {
                    nIsPrime = false;
                    break;
                }
            }
        }

        // n = 0 || n = 1 is not a prime number and they are not going into the loop so nIsPrime is false.
        if (nIsPrime)
        {
            Console.WriteLine($"{n} is a prime number");
        }
        else
        {
            Console.WriteLine($"{n} is NOT a prime number");
        }
    }

    public void Ex032()
    {
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        var m = (int)Math.Floor(Math.Sqrt((double)n));

        if (m * m == n)
        {
            Console.WriteLine($"{n} is a square number");
        }
        else
        {
            Console.WriteLine($"{n} is NOT a square number");
        }
    }

    public void Ex033()
    {
        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        var result = 0.0;

        for (var i = 0; i < n; ++i)
        {
            result = Math.Sqrt(2 + result);
        }

        Console.WriteLine($"S({n}) = {result}");
    }

    public void Ex034()
    {
        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        var result = 1.0;

        for (var i = 2; i <= n; ++i)
        {
            result = Math.Sqrt(i + result);
        }

        Console.WriteLine($"S({n}) = {result}");
    }


    public void Ex035() { }

    public void Ex036() { }
    public void Ex037() { }
    public void Ex038() { }
    public void Ex039() { }
    public void Ex040() { }
}

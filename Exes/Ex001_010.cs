/*
 * Note: I know it's a little bit tedious to write `Console.Write($"Result of S({n}) = ");` again and again,
 *       I can make another function to do that, but it will be hard to understand.
 */

namespace Exercises;

public partial class Program
{
    /// Starts with i=0
    public void Ex001()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0;
        for (var i = 0; i <= n; ++i)
        {
            result += i;
        }

        Console.WriteLine(result);
    }

    /// Starts with i=0
    public void Ex002()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0;
        for (var i = 0; i <= n; ++i)
        {
            result += i * i;
        }

        Console.WriteLine(result);
    }

    /// Starts with i=1
    public void Ex003()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0.0;
        for (var i = 1; i <= n; ++i)
        {
            result += 1.0 / i;
        }

        Console.WriteLine(result);
    }

    /// Starts with i=1
    public void Ex004()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0.0;
        for (var i = 1; i <= n; ++i)
        {
            result += 1.0 / (i * 2);
        }

        Console.WriteLine(result);
    }

    /// Start from i=0
    public void Ex005()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0.0;
        for (var i = 0; i <= n; ++i)
        {
            result += 1.0 / ((2 * i) + 1);
        }

        Console.WriteLine(result);
    }

    /// Start from i=1
    public void Ex006()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0.0;
        for (var i = 1; i <= n; ++i)
        {
            result += 1.0 / (i * (i + 1));
        }

        Console.WriteLine(result);
    }

    /// Start from i=1
    public void Ex007()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0.0;
        for (var i = 1; i <= n; ++i)
        {
            result += i / (i + 1.0);
        }

        Console.WriteLine(result);
    }

    /// Starts with i=0
    public void Ex008()
    {
        var n = ReadIntFromStdin("Input n: ");
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 0.0;
        for (var i = 0; i <= n; ++i)
        {
            result += (2 * i + 1.0) / (2 * i + 2);
        }

        Console.WriteLine(result);
    }

    /// Starts with i=1
    public void Ex009()
    {
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of T({n}) = ");

        var result = 1.0;
        for (var i = 1; i <= n; ++i)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }

    public void Ex010()
    {
        var x = ReadIntFromStdin("Input x: ", 0);
        if (x is null)
        {
            return;
        }

        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of T({x}, {n}) = ");

        if ((x == 0 && n == 0) || x == 1)
        {
            Console.WriteLine(1);
            return;
        }
        else if (x == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var result = (long)x;
        for (var i = 1; i < n; ++i)
        {
            result *= (long)x;
        }

        Console.WriteLine(result);
    }
}

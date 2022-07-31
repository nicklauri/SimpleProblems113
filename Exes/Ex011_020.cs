namespace Exercises;

public partial class Program
{
    /// Starts with i=2
    public void Ex011()
    {
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var result = 1UL;
        var product = 1UL;
        for (var i = 2UL; i <= (ulong)n; ++i)
        {
            product *= i;
            result += product;
        }

        Console.WriteLine(result);
    }

    public void Ex012()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        // From the formula, n >= 1
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var pow = x;
        var result = x;
        for (var i = 2; i <= n; ++i)
        {
            pow *= x;
            result += pow;
        }

        Console.WriteLine(result);
    }

    public void Ex013()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        // From the formula, n >= 1
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0)
        {
            Console.WriteLine(0);
            return;
        }

        // x^(2*n) = (x^2)^n = (x*x)^n
        var baseX = x * x;
        var pow = baseX;
        var result = baseX;
        for (var i = 2; i <= n; ++i)
        {
            pow *= baseX;
            result += pow;
        }

        Console.WriteLine(result);
    }

    public void Ex014()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0)
        {
            Console.WriteLine(0);
            return;
        }

        // x^(2*n + 1) = (x^2)^n*x = (x*x)^n*x
        var baseX = (long)(x * x);
        var pow = 1L;
        var result = x;
        for (var i = 1; i <= n; ++i)
        {
            pow *= baseX;
            result += pow * x;
        }

        Console.WriteLine(result);
    }

    public void Ex015()
    {
        // From the formula, n >= 1
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({n}) = ");

        var sum = 1UL;
        var result = 1.0;
        for (var i = 2; i <= n; ++i)
        {
            sum += (ulong)i;
            result += 1.0 / sum;
        }

        Console.WriteLine(result);
    }

    public void Ex016()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        // From the formula, n >= 1
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var pow = x;
        var product = 1L;
        var result = (double)x;
        for (var i = 2; i <= n; ++i)
        {
            pow *= x;
            product += (long)i;
            result += (double)pow / product;
        }

        Console.WriteLine(result);
    }

    public void Ex017()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        // From the formula, n >= 1
        var n = ReadIntFromStdin("Input n: ", 1);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var pow = x;
        var product = 1L;
        var result = (double)x;
        for (var i = 2; i <= n; ++i)
        {
            pow *= x;
            product *= (long)i;
            result += (double)pow / product;
        }

        Console.WriteLine(result);
    }

    public void Ex018()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0 || n == 0)
        {
            Console.WriteLine(1);
            return;
        }

        var baseX = (long)(x * x);
        var pow = 1L;
        var product = 1L;
        var result = (double)1;
        var perm = 1;
        for (var i = 2; i <= n; ++i)
        {
            pow *= baseX;
            product *= (long)perm * (long)(perm + 1);
            result += (double)pow / product;

            perm += 2;
        }

        Console.WriteLine(result);
    }

    // I don't know how an integer n would result in 1 for x^(2n+1)/(2n+1)!
    // But I will include it as default value when evaluating this formular.
    // This function 
    public void Ex019()
    {
        var x = (long?)ReadIntFromStdin("Input x: ");
        if (x is null)
        {
            return;
        }

        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Result of S({x}, {n}) = ");

        if (x == 0)
        {
            Console.WriteLine(1);
            return;
        }
        else if (n == 0)
        {
            Console.WriteLine(1 + x);
            return;
        }

        var baseX = (long)(x * x);
        var pow = (long)x;
        var product = 1L;
        var perm = 2;
        var result = 1.0 + x;   // 1.0 is from the formula.
        for (var i = 1; i <= n; ++i)
        {
            pow *= baseX;
            product *= (long)perm * (long)(perm + 1);
            result += (double)pow / product;

            perm += 2;
        }

        Console.WriteLine(result);
    }
    public void Ex020()
    {
        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Factors of {n} are: ");

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        Console.Write("1");
        for (var i = 2; i <= n; ++i)
        {
            if (n % i == 0)
            {
                Console.Write($", {i}");
            }
        }
    }
}

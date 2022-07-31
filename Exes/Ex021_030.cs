namespace Exercises;

public partial class Program
{
    public void Ex021()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Sum of factors of {n} is: ");

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var sum = 0UL;
        for (var i = 1UL; i <= n; ++i)
        {
            if (n % i == 0)
            {
                sum += (ulong)i;
            }
        }

        Console.WriteLine(sum);
    }

    public void Ex022()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Product of factors of {n} is: ");

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var product = 0UL;
        for (var i = 1UL; i <= n; ++i)
        {
            if (n % i == 0)
            {
                product *= i;
            }
        }

        Console.WriteLine(product);
    }

    public void Ex023()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Number of factors of {n} is: ");

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var count = 0UL;
        for (var i = 1UL; i <= n; ++i)
        {
            if (n % i == 0)
            {
                count += 1;
            }
        }

        Console.WriteLine(count);
    }

    public void Ex024()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        if (n == 0)
        {
            Console.WriteLine($"There is no odd factor for number {n}.");
            return;
        }
        else if (n >= 1)
        {
            Console.Write($"List of odd factors of {n} is: ");
            Console.Write(1);
        }

        for (var i = 3UL; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                Console.Write($", {i}");
            }
        }
    }

    public void Ex025()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Sum of even factors of {n} is: ");
        if (n < 2 || n % 2 != 0)
        {
            Console.Write(0);
            return;
        }

        var sum = 0UL;

        for (var i = 2UL; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }

    public void Ex026()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write("Product of odd factors for number {n} is: ");

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        else if (n < 3)
        {
            Console.WriteLine(1);
            return;
        }

        var product = 1UL;
        for (var i = 3UL; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                product *= i;
            }
        }

        Console.WriteLine(product);
    }

    public void Ex027()
    {
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Number of even factors of {n} is: ");

        var count = 0UL;

        for (var i = 2UL; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                count += 1;
            }
        }

        Console.WriteLine(count);
    }

    public void Ex028()
    {
        // See: Ex021()
        var n = (ulong?)ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        Console.Write($"Sum of factors of {n} is: ");

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        var sum = 0UL;
        for (var i = 1UL; i < n; ++i)
        {
            if (n % i == 0)
            {
                sum += (ulong)i;
            }
        }

        Console.WriteLine(sum);
    }

    public void Ex029()
    {
        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        if (n == 0)
        {
            Console.WriteLine($"There is no odd factor for number {n}");
            return;
        }

        Console.Write($"The biggest odd factor of {n} is: ");

        var biggestOddFactor = 1;

        for (var i = 3; i <= n; i += 2)
        {
            if (n % i == 0)
            {
                biggestOddFactor = i;
            }
        }

        Console.WriteLine(biggestOddFactor);
    }

    public void Ex030()
    {
        // See: Ex028()
        var n = ReadIntFromStdin("Input n: ", 0);
        if (n is null)
        {
            return;
        }

        var sum = 0;

        for (var i = 1; i < n; ++i)
        {
            if (n % i == 0)
            {
                sum += i;

                if (sum > n)
                {
                    break;
                }
            }
        }

        if (n > 2 && sum == n)
        {
            Console.WriteLine($"{n} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a perfect number.");
        }
    }
}

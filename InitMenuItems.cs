
namespace Exercises;

public partial class Program
{

    private List<MenuItem> InitMenuItems()
    {
        // Initialize list of actions, easy to create a menu.
        return new() {
            new("S(n) = 1 + 2 + ... + n", Ex001),
            new("S(n) = 1^2 + 2^2 + ... + n^2", Ex002),
            new("S(n) = 1 + 1/2 + ... + 1/n", Ex003),
            new("S(n) = 1/2 + 1/4 + ... + 1/2n", Ex004),
            new("S(n) = 1 + 1/3 + ... + 1/(2n + 1)", Ex005),
            new("S(n) = 1/2 + 1/6 +...+ 1/(n * (n + 1))", Ex006),
            new("S(n) = 1/2 + 2/3 + .... + n/(n + 1)", Ex007),
            new("S(n) = 1/2 + 3/4 + 5/6 + ... + (2n + 1)/(2n + 2)", Ex008),
            new("T(n) = 1 * 2 * 3 ... * n", Ex009),
            new("T(x, n) = x^n", Ex010),
            new("S(n) = 1 + 1*2 + 1*2*3 + ... + 1*2*3*...*N", Ex011),
            new("S(x, n) = x + x^2 + x^3 + ... + x^n", Ex012),
            new("S(x, n) = x^2 + x^4 + ... + x^2n", Ex013),
            new("S(x, n) = x + x^3 + x^5 + ... + x^(2n + 1)", Ex014),
            new("S(n) = 1 + 1/(1 + 2) + 1/(1 + 2 + 3) + ... + 1/(1 + 2 + 3 + ... + n)", Ex015),
            new("S(x, n) = x + x^2/(1 + 2) + x^3/(1 + 2 + 3) + ... + x^n/(1 + 2 + 3 + ... + n)", Ex016),
            new("S(x, n) = x + x^2/2! + x^3/3! + ... + x^n/n!", Ex017),
            new("S(x, n) = 1 + x^2/2! + x^4/4! + ... + x^2n/(2n)!", Ex018),
            new("S(n) = 1 + x + x^3/3! + x^5/5! + ... + x^(2n+1)/(2n+1)!", Ex019),
            new("List of factors of a number n (with n >= 0)", Ex020),
            new("Sum of factors of a number n (with n >= 0)", Ex021),
            new("Product of factors of a number n (with n >= 0)", Ex022),
            new("Count factors of a number n (with n >= 0)", Ex023),
            new("List of odd factors of a number n (with n >= 0)", Ex024),
            new("Sum of even factors of a number n (with n >= 0)", Ex025),
            new("Product of odd factors of a number n (with n >= 0)", Ex026),
            new("Count even factors of a number n (with n >= 0)", Ex027),
            new("Sum of factors that less than n of a number n (with n >= 0)", Ex028),
            new("Find the biggest odd factor of a number n (with n >= 0)", Ex029),
            new("Check if n (n >= 0) is a perfect number", Ex030),
        };
    }
}

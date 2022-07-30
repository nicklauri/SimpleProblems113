
namespace BaiTap;

public partial class Program
{

    public List<MenuItem> InitMenuItems()
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
        };
    }
}

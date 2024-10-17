public class Solution
{
    public static int Reverse(int x)
    {
        int sur = 0;
        double newnum = 0;
        bool isPositive = true;
        if (x < 0)
        {
            isPositive = false;
            x *= -1;
        }

        while (x is not 0)
        {
            sur = x % 10;
            newnum = newnum * 10 + sur;
            x /= 10;
        }
        newnum = isPositive ? newnum : -newnum;
        if (newnum >= 2147483647 || newnum <= -2147483648) return 0;

        return (int)newnum;
    }

    public static void Main(string[] args)
    {
        int newnum = Reverse(-123);
        Console.WriteLine(newnum);
    }
}

public class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int rev = Reverse(x);
        if (x == rev)
            return true;
        return false;
    }

    private static int Reverse(int x)
    {
        int sur = 0;
        int newnum = 0;

        while (x is not 0)
        {
            sur = x % 10;
            newnum = newnum * 10 + sur;
            x /= 10;
        }

        return newnum;
    }

    public static void Main(string[] args)
    {
        bool result1 = IsPalindrome(123);
        bool result2 = IsPalindrome(121);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}
public class Solution
{
    public static bool IsMatch(string s, string p)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < p.Length)
        {
            if (p[j] == s[i] || p[j] == '.')
            {
                i++;
                j++;
            }
            else if (p[j] == '*')
            {
                for (; i < s.Length; i++)
                {
                    if (p[j] == s[i])
                    {
                        i++;
                        j++;
                        break;
                    }
                }
                if (i == s.Length && j == p.Length - 1) return true;
            }
            else return false;
        }
        if (i == s.Length - 1 && j == p.Length - 1) return true;
        return false;
    }

    public static void Main(string[] args)
    {
        bool result1 = IsMatch("aab", "c*a*b");
        Console.WriteLine(result1);
        //bool result2 = IsMatch("aa", "a*");

        //Console.WriteLine(result2);
    }
}
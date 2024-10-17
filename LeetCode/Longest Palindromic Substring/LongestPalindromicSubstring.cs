public class Solution
{
    public static string LongestPalindrome(string s)
    {
        int i = 0, j;
        int pos = 0;
        int MaxLength = 0;
        while (i < s.Length)
        {
            for (j = i + 1; j < s.Length; j++)
            {
                if (s[j] == s[i] && ((j - i) > MaxLength))
                {
                    MaxLength = j - i + 1;
                    pos = j;
                }
            }
            i++;
        }
        return s.Substring(pos - MaxLength + 1, MaxLength);
    }

    public static void Main(string[] args)
    {
        string MaxLength = LongestPalindrome("cbbd");
        Console.WriteLine(MaxLength);
    }
}
using System.Text;

public class Solution
{
    public static string LongestPalindrome(string s)
    {
        int left = 0, right;
        int i = 0, pos = 0;
        int MaxLength = 0;
        while (i < s.Length)
        {
            left = i;
            for (right = left; right < s.Length; right++)
            {
                if (s[right] == s[left] && ((right - left + 1) > MaxLength))
                {
                    int ls = left, rs = right;
                    while (ls <= rs)
                    {
                        if (s[ls] == s[rs])
                        {
                            if (ls + 1 == rs || ls == rs)
                            {
                                MaxLength = right - left + 1;
                                pos = left;
                            }
                        }
                        else break;
                        ls++; rs--;
                    }
                }
            }
            i++;
        }
        return s.Substring(pos, MaxLength);
    }

    public static string Console1(string s, int numRows)
    {
        int step1 = 2 * numRows - 2;
        int step2 = 0;
        int i = 0;
        StringBuilder strb = new StringBuilder();
        if (numRows >= s.Length || numRows == 1) return s;
        while (i < numRows)
        {
            strb.Append(s[i]);
            for (int j = i; (j + step1 < s.Length && step1 > step2 && step2 != 0) || (j + step1 < s.Length && step1 < step2 && step1 != 0)
                || j + step1 + step2 < s.Length || step1 == step2;)
            {
                if (j + step1 < s.Length && step1 != 0)
                {
                    j += step1;
                    strb.Append(s[j]);

                }
                if (j + step2 < s.Length && step2 != 0)
                {
                    j += step2;
                    strb.Append(s[j]);
                }
                if (j + step2 >= s.Length) break;
            }
            step1 -= 2;
            step2 += 2;
            i++;
        }
        return strb.ToString();
    }

    public static void Main(string[] args)
    {
        string MaxLength = LongestPalindrome("xaabacxcabaaxcabaax");
        string console1 = Console1("PAYPALISHIRING", 5);
        Console.WriteLine(console1);
    }
}
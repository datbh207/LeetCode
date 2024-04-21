using System.Text;

namespace LeetCode
{
    public class Solution
    {
        public static string Console1(string s, int numrows)
        {
            int step1 = 2 * numrows - 2;
            int step2 = 0;
            int i = 0;
            StringBuilder strb = new StringBuilder();
            while (i < numrows)
            {
                strb.Append(s[i]);
                for (int j = i; j < s.Length;)
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
                }
                step1 -= 2;
                step2 += 2;
                i++;
            }
            return strb.ToString();
        }

        public static void Main(string[] args)
        {
            string MaxLength = Console1("ABCDEFGHIKLMN", 5);
            Console.WriteLine(MaxLength);
        }
    }
}


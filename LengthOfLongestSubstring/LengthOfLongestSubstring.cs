namespace LeetCode
{
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> hash = new HashSet<char>();
            int i = 0, j;
            int MaxLength = 0;
            while (i < s.Length)
            {
                for (j = i; j < s.Length; j++)
                {
                    if (!hash.Contains(s[j]))
                    {
                        hash.Add(s[j]);
                        MaxLength = hash.Count > MaxLength ? hash.Count : MaxLength;
                    }
                    else
                    {
                        hash.Clear();
                        break;
                    }
                }
                i++;
            }
            return MaxLength;
        }

        public static void Main(string[] args)
        {
            int MaxLength = LengthOfLongestSubstring("aab");
            Console.WriteLine(MaxLength);
        }
    }
}
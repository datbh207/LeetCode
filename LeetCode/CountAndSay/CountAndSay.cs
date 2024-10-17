namespace CountAndSay
{
    public class Solution_CountAndSay
    {
        public string CountAndSay(int n)
        {
            string s = "1";
            if (n == 1)
                return s;
            for (int i = 1; i < n; i++)
            {
                s = GetNewString(s);
            }

            return s;
        }

        public string GetNewString(string s)
        {
            int n = s.Length;
            string newString = "";
            char index = s[0];
            int count = 1;
            for (int j = 1; j < n; j++)
            {
                if (s[j] == index)
                    count++;
                else
                {
                    newString += count.ToString() + index;
                    count = 1;
                    index = s[j];
                }
            }
            newString += count.ToString() + index;
            return newString;
        }

        public static void Main(string[] args)
        {
            Solution_CountAndSay solution = new Solution_CountAndSay();

            for (int n = 1; n <= 5; n++)
            {
                string result = solution.CountAndSay(n);
                Console.WriteLine("CountAndSay(" + n + ") = " + result);
            }

            Console.ReadLine();
        }
    }
}

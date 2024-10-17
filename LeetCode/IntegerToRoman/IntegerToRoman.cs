namespace LeetCode
{
    public class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            if (num >= 1000)
            {
                return "M" + IntToRoman(num - 1000);
            }
            else if (num >= 100)
            {
                return (num / 100 == 9) ? "CM" + IntToRoman(num - 900) :
                    (num / 100 >= 5) ? "D" + IntToRoman(num - 500) :
                    (num / 100 == 4) ? "CD" + IntToRoman(num - 400) : "C" + IntToRoman(num - 100);
            }
            else if (num >= 10)
            {
                return (num / 10 == 9) ? "XC" + IntToRoman(num - 90) :
                    (num / 10 >= 5) ? "L" + IntToRoman(num - 50) :
                    (num / 10 == 4) ? "XL" + IntToRoman(num - 40) : "X" + IntToRoman(num - 10);

            }
            else if (num >= 1)
            {
                return (num == 9) ? "IX" + IntToRoman(num - 9) :
                    (num >= 5) ? "V" + IntToRoman(num - 5) :
                    (num == 4) ? "IV" + IntToRoman(num - 4) : "I" + IntToRoman(num - 1);
            }

            return "";
        }

        public static void Main(String[] args)
        {
            Console.WriteLine(IntToRoman(58));
        }
    }
}
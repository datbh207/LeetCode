namespace ValidParentheses;
/*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.


Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([])"
Output: true*/

public class ValidParentheses
{
    public static bool IsValid(string s)
    {
        IDictionary<char, int> open = new Dictionary<char, int>();
        IDictionary<char, int> close = new Dictionary<char, int>();

        open.Add('(', 0);
        open.Add('{', 1);
        open.Add('[', 2);

        close.Add(')', 0);
        close.Add('}', 1);
        close.Add(']', 2);

        Stack<int> stack = new Stack<int>();
        foreach (char c in s.ToCharArray())
        {
            if (open.ContainsKey(c))
            {
                open.TryGetValue(c, out int value);
                stack.Push(value);
            }
            else if (close.ContainsKey(c))
            {
                close.TryGetValue(c, out int value);
                var haveValue = stack.TryPop(out int lastvalue);
                if (!haveValue || lastvalue != value)
                    return false;
            }
        }
        return stack.Any() ? false : true;
    }

    public static void Main(string[] args)
    {
        string s = "(]";
        var result = IsValid(s);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

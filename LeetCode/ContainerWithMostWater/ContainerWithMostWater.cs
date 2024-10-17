
namespace LeetCode
{
    public class Solution
    {
        public static int MaxArea(int[] height)
        {
            int maxWater = 0;
            int left = 0, right = height.Length - 1;
            while (left < right)
            {
                int index;
                if (height[left] < height[right])
                {
                    index = height[left] * (right - left);
                    left++;
                }
                else
                {
                    index = height[right] * (right - left);
                    right--;
                }
                maxWater = (maxWater > index) ? maxWater : index;
            }
            return maxWater;
        }

        public static void Main(string[] args)
        {
            int MaxLength = MaxArea(new int[] { 1, 1 });
            Console.WriteLine(MaxLength);
        }
    }
}
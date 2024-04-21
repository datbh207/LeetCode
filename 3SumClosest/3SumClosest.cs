namespace ThreeSumClosest
{
    public class _ThreeSumClosest
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int start = 0, left, right;
            int result = nums[0] + nums[1] + nums[2];
            if (nums.Length == 3) return result;
            while (start < nums.Length - 2)
            {
                left = start + 1;
                right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[start] + nums[left] + nums[right];
                    if (sum > target)
                    {
                        --right;
                    }
                    else if (sum <= target)
                    {
                        ++left;
                    }
                    result = Math.Abs(sum - target) > Math.Abs(result - target) ? result : sum;
                }
                int currentStartNumber = nums[start];
                while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                    ++start;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            var result = ThreeSumClosest(new int[] { 1, 1, 1, 1 }, 3);
            Console.WriteLine(result);
        }
    }
}

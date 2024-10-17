namespace SearchInsertPosition
{
    public class Solution_SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    left = mid + 1;
                else right = mid - 1;
            }
            return left;
        }

        public static void Main(string[] args)
        {
            int[] nums = [1, 3, 5, 6, 7];
            int target = 2;
            var result = SearchInsert(nums, target);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

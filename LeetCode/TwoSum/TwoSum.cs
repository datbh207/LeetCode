using System.Collections;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Hashtable hash = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int complete = target - nums[i];
                if (hash.ContainsKey(complete))
                {
                    return new int[] { (int)hash[complete], i };
                }
                hash[nums[i]] = i;
            }
            return new int[] { 0, 0 };
        }
    }
}

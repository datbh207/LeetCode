namespace LeetCode
{
    public class Solution
    {

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0, count = 0;
            double[] nums = new double[nums1.Length + nums2.Length];
            while (count < nums1.Length + nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    nums[count] = nums1[i];
                    i++;
                }
                else
                {
                    nums[count] = nums2[j];
                    j++;
                }
                count++;
            }
            int mid = (count - 1) / 2;
            return ((count - 1) % 2 == 0) ? nums[mid] : (nums[mid] + nums[mid + 1]) / 2; ;
        }
        //public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    int i = 0, j = 0, count = 0;
        //    double[] nums = new double[nums1.Length + nums2.Length];
        //    while (i < nums1.Length && j < nums2.Length)
        //    {
        //        if (nums1[i] < nums2[j])
        //        {
        //            nums[count] = nums1[i];
        //            i++;
        //        }
        //        else
        //        {
        //            nums[count] = nums2[j];
        //            j++;
        //        }
        //        count++;
        //    }
        //    while (i < nums1.Length)
        //    {
        //        nums[count] = nums1[i];
        //        i++;
        //        count++;
        //    }
        //    while (j < nums2.Length)
        //    {
        //        nums[count] = nums2[j];
        //        j++;
        //        count++;
        //    }
        //    int mid = (count - 1) / 2;
        //    return ((count - 1) % 2 == 0) ? nums[mid] : (nums[mid] + nums[mid + 1]) / 2; ;
        //}

        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 3 };
            int[] b = new int[] { 2, 4 };
            double result = FindMedianSortedArrays(a, b);
            Console.WriteLine(result);
        }
    }
}

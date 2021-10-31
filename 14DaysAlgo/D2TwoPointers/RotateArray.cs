using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.D2TwoPointers
{
    public class RotateArray
    {
        public int[] RotateRight(int[] nums, int k)
        {
            k %= nums.Length;
            reverser(nums, 0, nums.Length - 1);
            reverser(nums, 0, k - 1);
            reverser(nums, k, nums.Length - 1);

            return nums;
        }

        public static int[] reverser(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }

            return nums;
        }

        public static List<int> RotateLeft(int d, List<int> arr)
        {
            d %= arr.Count;
            reversel(arr, d, arr.Count - 1);
            reversel(arr, 0, d - 1);
            reversel(arr, 0, arr.Count - 1);

            return arr;
        }

        public static List<int> reversel(List<int> arr, int start, int end)
        {
            while (end > start)
            {
                int temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;
                end--;
                start++;
            }
            return arr;
        }
    }
}

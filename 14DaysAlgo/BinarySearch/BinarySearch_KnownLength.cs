using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.BinarySearch
{
    public class BinarySearch_KnownLength
    {
        public static int Search(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }
    }
}

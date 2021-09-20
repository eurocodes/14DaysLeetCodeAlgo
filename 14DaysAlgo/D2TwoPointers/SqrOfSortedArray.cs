using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.D2TwoPointers
{
    public class SqrOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] squres = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                squres[i] = nums[i] * nums[i];
            }

            return squres.OrderBy(x => x).ToArray();
        }
    }
}

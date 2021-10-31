using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.D3TwoPointers
{
    public class MoveZeroes
    {
        public static void MoveZeroess(int[] nums)
        {
            int lastNonZeroFountAt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroFountAt++] = nums[i];
                }
            }

            for (int j = lastNonZeroFountAt; j < nums.Length; j++)
            {
                nums[j] = 0;
            }
        }
    }
}

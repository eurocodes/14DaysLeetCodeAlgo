using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.BinarySearch.BS_UnknownLength
{
    public class CheckBadVersion: VersionControl
    {
        public static int FirstBadVersion(int n)
        {
            int min = 1;
            int max = n;
            while (min < max)
            {
                int mid = min + (max - min) / 2;
                if (IsBadVersion(mid))
                {
                    max = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return min;
        }
    }
}

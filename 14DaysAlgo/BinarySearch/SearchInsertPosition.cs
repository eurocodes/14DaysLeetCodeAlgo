using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.BinarySearch
{
    public class SearchInsertPosition
    {
        public static int SearchInsert(int[] arr, int target)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if(target == arr[mid])
                {
                    return mid;
                }
                else if (target < arr[min])
                {
                    return min;
                }
                else if (target > arr[max])
                {
                    return max + 1;
                }
                else if(target > arr[mid] && target < arr[mid + 1])
                {
                    return mid + 1;
                }
                else if(target > arr[mid])
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

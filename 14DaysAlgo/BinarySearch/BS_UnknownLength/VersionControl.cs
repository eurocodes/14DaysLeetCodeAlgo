using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DaysAlgo.BinarySearch.BS_UnknownLength
{
    public class VersionControl
    {
        public static bool IsBadVersion(int num)
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "G");
            numbers.Add(2, "G");
            numbers.Add(3, "G");
            numbers.Add(4, "G");
            numbers.Add(5, "G");
            numbers.Add(6, "B");
            numbers.Add(7, "B");
            numbers.Add(8, "B");

            numbers.TryGetValue(num, out string val);
            if (val == "B")
                return true;
            return false;


        }

    }
}

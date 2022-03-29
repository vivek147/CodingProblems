using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin.BinarySearch
{
    public class CountElementOccurence
    {
        //public static void Main()
        //{
        //    List<int> a1 = new List<int> { 1, 2, 6, 9, 9 }; //0,1,2,3

        //    var result
        //      = ElementOccurence(a1, 2);
        //}

        private static int ElementOccurence(List<int> list, int target)
        {
            int ans = 0;

            int start = 0;
            int end = list.Count - 1;

            for (int i = start; i <= end; i++)
            {
                if (list[i] == target)
                {
                    ans = ans + 1;
                    continue;
                }

                if (ans > 0) return ans;

                int mid = start + (end - start) / 2;

                if (list[mid] == target)
                {
                    ans = ans + 1;
                    
                    int midnext = mid;
                    while (midnext < end && list[midnext + 1] == target)
                    {
                        midnext = midnext + 1;
                        ans = ans + 1;
                    }

                    int midPrev = mid;
                    while (midPrev > start && list[midPrev - 1] == target)
                    {
                        midPrev = midPrev - 1;
                        ans = ans + 1;
                    }

                    if (ans > 0) return ans;
                }

                if (list[mid] > target)
                {
                    end = mid - 1;
                }

                if (list[mid] < target)
                {
                    start = mid + 1;
                }
            }

            return ans;
        }
    }
}

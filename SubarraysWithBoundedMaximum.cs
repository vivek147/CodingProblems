using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class SubarraysWithBoundedMaximum
    {

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    //var res = NumSubarrayBoundedMax(new int[] { 2,2,2,2,2,2,2,2,2,2,2,2 }, 1, 2);
        //    var res = NumSubarrayBoundedMax(new int[] { 2, 1, 4, 3 }, 2, 3);
        //    //fun(new List<int> { 5, 4, 2, 1, 3 });
        //    //fun(new List<int> { 2, 1, 3 });
        //    //fun(new List<int> { 4, 3, 5, 4, 3 });

        //    Console.ReadKey();
        //}
        public static int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {

            int result = 0;
            int window = 0;
            int start = 0;
            int end = 0;

            while (end < nums.Length)
            {
                if (nums[end] > right)
                {
                    start = end + 1;
                    window = 0;
                }

                if (left <= nums[end] && nums[end] <= right)
                {
                    window = end - start + 1;
                }

                //if (nums[end] < left)
                //{
                //    window = 0;
                //}

                result += window;

                end++;
            }

           return result;
        }
    }
}

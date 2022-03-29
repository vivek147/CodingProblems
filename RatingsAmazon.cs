using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class RatingsAmazon
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
            int number = 0;
            int start = 0, end = -1;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (left <= nums[i] && nums[i] <= right) end = i;

                if (nums[i] > right)
                {
                    start = i + 1;
                }
                else if (end >= start)
                {
                    number += end - start + 1;
                }
            }

            return number;
            //int output = 0;

            //for (int i = 0; i <= nums.Length; i++)
            //{
            //    String res = "";
            //    int maxelement = 0;
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //       // res += nums[j] + " ";
            //        maxelement = maxelement < nums[j] ? nums[j] : maxelement;

            //        if (maxelement < left)
            //            continue;

            //        if (maxelement <= right && maxelement >= left)
            //        {
            //            output++;
            //        }
            //        else
            //            j = nums.Length;

            //       // Console.WriteLine(res);
            //    }
            //}
            //return output;

            //int n = nums.Length;

            //int ans = 0, i = 0, j = 0, prev = 0;

            //int k = 0;

            //while (j < n)
            //{

            //    if (nums[j] <= right && nums[j] >= left)
            //    {

            //        prev = (j - i + 1);
            //        ans += prev;
            //        j++;

            //    }
            //    else if (nums[j] < left)
            //    {

            //        ans += prev;
            //        j++;

            //    }
            //    else
            //    {
            //        prev = 0;
            //        j++;
            //        i = j;
            //    }


            //}

            //return ans;
        }

        public static long fun(List<int> ratings)
        {
            long load = 0;
            long ans = 0;
            for (int i = 0; i < ratings.Count(); i++)
            {
                if (load == 0)
                {
                    load = 1;
                }
                else
                {
                    if (ratings.ElementAt(i - 1) == ratings.ElementAt(i) + 1)
                    {
                        load++;
                    }
                    else
                    {
                        ans += sumOfNNaturalNumbers(load);
                        load = 1;
                    }
                }
            }
            ans += sumOfNNaturalNumbers(load);

            return ans;
        }

        private static long sumOfNNaturalNumbers(long n)
        {
            if (n % 2 == 0)
                return ((n / 2) * (n + 1));
            else
                return n * ((n + 1) / 2);
        }
    }
}

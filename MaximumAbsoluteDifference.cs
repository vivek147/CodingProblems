using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class MaximumAbsoluteDifference
    {
        //public static void Main()
        //{
        //    var result = CalculateMaximumAbsoluteDifference(new List<int> { 1, 3, -1 });
        //}

        private static int CalculateMaximumAbsoluteDifference(List<int> list)
        {
            int max = 0;

            int max1 = int.MinValue;
            int min1 = int.MaxValue;
            int max2 = int.MinValue; 
            int min2 = int.MaxValue;

            //| A[i] - A[j] | + | i - j |
            for (int i=0;i<list.Count;i++)
            {
                //a[i]+i  - (a[j] + j)
                //a[i]-i + (a[j]-j)
                
                var tempSum = list[i] + i;
                //a[i]+i 
                if (tempSum > max1)
                    max1 = tempSum;
                //(a[j] + j)
                if (tempSum < min1)
                    min1 = tempSum;

                 
                tempSum = list[i] - i;
                //a[i]-i
                if (tempSum > max2)
                    max2 = tempSum;
                //(a[j] - j)
                if (tempSum < min2)
                    min2 = tempSum;
            }
            max = System.Math.Max(max1-min1, max2- min2);
            return max;
        }
    }
}


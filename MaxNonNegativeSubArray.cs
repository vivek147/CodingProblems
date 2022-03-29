using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
   public class MaxNonNegativeSubArray
    {
        //public static void Main()
        //{
        //    var result = MaxNonNegativeSubArr(new List<int> { 336465782, -278722862, -2145174067, 1101513929, 1315634022, -1369133069, 1059961393, 628175011, -1131176229, -859484421  });
        //    result = MaxNonNegativeSubArr(new List<int> { 0, 0, -1, 0 });
        //}


        public static List<int> MaxNonNegativeSubArr(List<int> A)
        {
            List<int> result = new List<int>();

            int start = 0;
            int end = 0;
           
            int curr_segmentlength = 0;
            int curr_minStartingIndex = 0;
            int segmentlength = 0;
            int minStartingIndex = 0;

            long sum = 0;
            long maxSum = 0;
            
            while (end < A.Count())
            {
                
                if (A[end] < 0)
                {
                    start = end + 1;
                    sum = 0;
                }
                else
                {
                    curr_segmentlength = end - start + 1;
                    curr_minStartingIndex = start;

                    sum += A[end];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        minStartingIndex = curr_minStartingIndex;
                        segmentlength = curr_segmentlength;
                    }
                    else if(maxSum == sum && segmentlength < curr_segmentlength)
                    {
                        segmentlength = curr_segmentlength;
                        minStartingIndex = curr_minStartingIndex;
                    }
                    else if (maxSum == sum && segmentlength == curr_segmentlength && minStartingIndex < curr_minStartingIndex)
                    {
                       // minStartingIndex = minStartingIndex;
                    }
                }

                end++;
            }

            //print output
            for(int i=minStartingIndex;i < (segmentlength+minStartingIndex) ; i++ )
            {
                result.Add(A[i]);
            }

            return result;
        }
    }
}

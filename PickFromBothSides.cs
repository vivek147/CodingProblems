using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class PickFromBothSides
    {
        //public static void Main()
        //{
        //    var result = solve(new List<int> { 5, -2, 3, 1, 2 }, 3);
        //}


        public static int solve(List<int> A, int B)
        {
            int start = 0;
            int totalelemens = B;
            int current_sum = 0;
            int end = A.Count() - 1;

            //sum from starting to B
            while (totalelemens > 0)
            {
                current_sum += A[start];
                totalelemens--;

                if(totalelemens > 0)
                  start++;
            }

            int answer = current_sum;

            //sum after excluding element
            while (start >= 0 && end >= 0)
            {
                current_sum += A[end];
                end--;
                current_sum -= A[start];
                start--;

                answer = current_sum > answer ? current_sum : answer;
            }

            return answer;
        }

    }
}

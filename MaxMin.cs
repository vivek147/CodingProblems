using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    class MaxMin
    {
        //public static void Main()
        //{
        //    List<int> A = new List<int> { -2, 1, -4, 5, 3 };
        //    List<int> B = new List<int> { 1, 3, 4, 1 };
        //    var result = maxMin(A);
        //    result = maxMin(B);
        //}


        public static int maxMin(List<int> A)
        {
            int lengthofA = A.Count();
            int max = A[0];
            int min = A[0];

            for(int i=1;i<lengthofA;i++)
            {
                if (A[i] > max)
                    max = A[i];

                if (A[i] < min)
                    min = A[i];
            }

            return max + min;

        }
    }
}

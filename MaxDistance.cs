using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class MaxDistance
    {
        // Given an array A of integers, find the maximum of j - i subjected to the constraint of A[i] <= A[j].
        //public static void Main()
        //{
        //    List<int> a1 = new List<int> { 3, 5, 4, 2 }; //0,1,2,3

        //    var result = MaxDistanceSolve(a1);
        //}

        public static int MaxDistanceSolve(List<int> A)
        {
            List<List<int>> ArrayWithIndex = new List<List<int>>();

            for (int i = 0; i < A.Count; i++)
            {
                ArrayWithIndex.Add(new List<int> { A[i], i });
            }

            var sortedarraywithIndex = ArrayWithIndex.OrderBy(s => s[0]).ToList();

            int max = 0;
            int imin = int.MaxValue;

            for (int i = 0; i < sortedarraywithIndex.Count; i++)
            {
                imin = Math.Min(imin, sortedarraywithIndex[i][1]);
                //check for j-i
                max = Math.Max(sortedarraywithIndex[i][1] - imin , max);
            }

            return max;
        }
    }
}

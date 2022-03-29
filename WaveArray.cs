using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class WaveArray
    {
        //public static void Main()
        //{
        //    List<int> a1 = new List<int> { 1, 2, 3, 4 };

        //    var result = Wave(a1);
        //}

        public static List<int> Wave(List<int> A)
        {
            A.Sort();

            //Swap
            for (int i = 0; i < A.Count() - 1; i++)
            {
                var temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp;

                i++;
            }

            return A;
        }
    }
}
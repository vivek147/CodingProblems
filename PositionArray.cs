using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
   public class PositionArray
    {
        //public static void Main()
        //{
        //    var result = rotateArray(new List<int> { 14, 5, 14, 34, 42, 63, 17, 25, 39, 61, 97, 55, 33, 96, 62, 32, 98, 77, 35 }, 56);
        //    // result = solve(new List<int> { 5, -2, 3, 1, 2 }, 3);
        //}


        public static List<int> rotateArray(List<int> A, int B)
        {
            List<int> ret = new List<int>();

            //var test = B % A.Count();

            for (int i = 0; i < A.Count(); i++)
            {
                ret.Add(A.ElementAt((i + B) % A.Count()));
            }

            return ret;
        }

    }
}

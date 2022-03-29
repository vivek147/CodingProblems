using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class PowerOfN
    {
        //public static void Main()
        //{
            

        //    // var result = SetMatrixZerosSolve(new List<List<int>> { a1, a2, a3 });
        //    var result = PowerOfTwoInteger(8);
        //}

        private static bool PowerOfTwoInteger(int number)
        {
            if (number == 0)
                return false;

            for(int i=2;i<Math.Sqrt(number);i++)
            {
                int val = i;
                while(val <= number && number % val == 0)
                {
                    if (val == number)
                        return true;

                      val = val * i;
                }
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace testAppCoin
{
    public class Findfactorials
    {
        //public static void Main()
        //{
        //    var result = getFactorial(5);
        //}


        public static string getFactorial(int A)
        {
            return factorial(A);
        }

        private static string factorial(int a)
        {
            int[] arr = new int[1000] ;

            if (a == 0)
                return "1";

            arr[0] = 1;
            int len = 1;

            int index = 0;
            int carry = 0;

            for (int i = 2; i <= a; i++)
            {
                index = 0;
                carry = 0;

                while (index < len)
                {

                    var res = i * arr[index] + carry;
                    var factVal = res % 10;
                    carry = res / 10;
                    arr[index] = factVal;
                    index++;
                }

                while (carry > 0)
                {
                    arr[len] = carry % 10;
                    carry = carry / 10;
                    len++;
                }

            }
             System.Text.
            StringBuilder result = new System.Text.StringBuilder();

            for (int i = len-1; i >=0; i--)
            {
                result.Append(arr[i]);
            }

            return result.ToString();
        }

        //private static double factorial(int a)
        //{
        //    double result = 1;

        //    for(int i=1; i<= a; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}
    }
}

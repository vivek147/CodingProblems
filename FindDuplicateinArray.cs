using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class FindDuplicateinArray
    {
        //public static void Main()
        //{

        //    List<int> dupeArray = new List<int> { 2, 2, 3,1,2,3, 6, 6 };
        //    printRepeating(dupeArray.ToArray(), dupeArray.Count());
        //    var result = Solve(dupeArray);
        //}

        static void printRepeating(int[] arr, int size)
        {
            int i;

            Console.Write("The repeating" +
                          " elements are : ");

            for (i = 0; i < size; i++)
            {
                int j = Math.Abs(arr[i]);
                if (arr[j] >= 0)
                    arr[j] = -arr[j];
                else
                    Console.Write(j + " ");
            }
        }

        public static int Solve(List<int> A)
        {
            Dictionary<int,int> arraycount = new Dictionary<int, int>();
            for (int i = 0; i < A.Count(); i++)
            {
                if (arraycount.ContainsKey(A[i]))
                    return A[i];
                else
                    arraycount.Add(A[i],1);
            }

            return -1;
        }
    }
}

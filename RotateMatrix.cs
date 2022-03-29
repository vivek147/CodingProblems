using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class RotateMatrix
    {
        //public static void Main()
        //{
        //    List<List<int>> A = new List<List<int>>();


        //    List<int> a1 = new List<int> { 1, 2 };
        //    List<int> a2 = new List<int> { 3, 4 };

        //    A.Add(a1);
        //    A.Add(a2);

        //    var result = Rotate(A);
        //}

        public static List<List<int>> Rotate(List<List<int>> A)
        {
            //transpose array
            for (int i = 0; i < A.Count(); i++)
            {
                for(int j=i;j < A.Count();j++)
                {
                    var arrtmp = A[i][j];
                    A[i][j] = A[j][i];
                    A[j][i] = arrtmp;
                }
            }

            //Reverse array
            for (int i = 0; i < A.Count(); i++)
            {
                int length = A.Count();
                for (int j = 0; j < length; j++)
                {
                    var arrtmp = A[i][j];
                    A[i][j] = A[i][length - 1];
                    A[i][length - 1] = arrtmp;
                    length--;
                }
            }

            return A;
        }
    }
}
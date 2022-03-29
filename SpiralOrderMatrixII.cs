using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class SpiralOrderMatrixII
    {
        //public static void Main()
        //{
        //    var result = GetSpiralOrderMatrixII(3);
        //}

        private static List<List<int>> GetSpiralOrderMatrixII(int A)
        {
            List<List<int>> sprialmatrix = new List<List<int>>();

            int left = 0;
            int right = A - 1;
            int top = 0;
            int bottom = A-1;

            /* initialize elements of array n */
            for (int i = 0; i < A; i++)
            {
                List<int> arr = new List<int>();
                for (int j=0;j<A;j++)
                {
                    arr.Add(j);
                }
                sprialmatrix.Add(arr);
            }

            int val = 0;
            while (left<=right && top <=bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    sprialmatrix[top][i] = val = val + 1;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    sprialmatrix[i][right] = val = val + 1;
                }

                right--;

                for (int i = right; i >= left; i--)
                {
                    sprialmatrix[bottom][i] = val = val + 1;
                }

                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    sprialmatrix[i][left] = val = val + 1;
                }

                left++;
            }
            var res = sprialmatrix;
            return res;
        }
    }
}

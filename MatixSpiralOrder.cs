using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
   public class MatixSpiralOrder
    {
        //public static void Main(string[] args)
        //{
        //    //List<List<int>> b = new List<List<int>>();
        //    //b.Add(new List<int> { 1 ,2});
        //    //var outp = spiralOrder(b);

        //    List<List<int>> A = new List<List<int>>();
        //    A.Add(new List<int> { 1 });
        //    A.Add(new List<int> { 2 });
        //    A.Add(new List<int> { 3 });
        //    var outp = spiralOrder(A);

        //    //A.Add(new List<int> { 335, 401, 128, 384, 345, 275, 324, 139, 127, 343, 197, 177, 127, 72, 13, 59 });
        //    //A.Add(new List<int> { 102, 75, 151, 22, 291, 249, 380, 151, 85, 217, 246, 241, 204, 197, 227, 96 });
        //    //A.Add(new List<int> { 261, 163, 109, 372, 238, 98, 273, 20, 233, 138, 40, 246, 163, 191, 109, 237 });
        //    //A.Add(new List<int> { 179, 213, 214, 9, 309, 210, 319, 68, 400, 198, 323, 135, 14, 141, 15, 168 });
        //    //var outp = spiralOrder(A);

        //    //[335, 401, 128, 384, 345, 275, 324, 139, 127, 343, 197, 177, 127, 72, 13, 59]
        //    //[102, 75, 151, 22, 291, 249, 380, 151, 85, 217, 246, 241, 204, 197, 227, 96]
        //    //[261, 163, 109, 372, 238, 98, 273, 20, 233, 138, 40, 246, 163, 191, 109, 237]
        //    //[179, 213, 214, 9, 309, 210, 319, 68, 400, 198, 323, 135, 14, 141, 15, 168]

        //}

        public static List<int> spiralOrder(List<List<int>> A)
        {
            //left      //right
            //top //[ 1, 2, 3 ], 
            //[ 4, 5, 6 ], 
            //bottom//[ 7, 8, 9 ]

            var outlist = new List<int>();

            int left = 0;
            int right = A[0].Count() - 1;
            int top = 0;
            int bottom = A.Count() - 1;

            while (bottom >= top && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    outlist.Add(A[top][i]);
                }
                top++;

                if (bottom >= top && left <= right)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        outlist.Add(A[i][right]);
                    }
                }

                right--;

                if (bottom >= top && left <= right)
                {
                    for (int i = right; i >= left; i--)
                    {
                        outlist.Add(A[bottom][i]);
                    }
                }

                bottom--;

                if (bottom >= top && left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        outlist.Add(A[i][left]);
                    }
                }

                left++;
            }
            return outlist;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testAppCoin
{
    class MinStepsinInfiniteGrid
    {
        //public static void Main()
        //{
        //    List<int> A = new List<int> { 4, 8, -7, -5, -13, 9, -7, 8 };
        //    List<int> B = new List<int> { 4, -15, -10, -3, -13, 12, 8, -8 };
        //    var result = coverPoints(A, B);
        //}


        public static int coverPoints(List<int> A, List<int> B)
        {
            int lengthofA = A.Count();
            int lengthofb = B.Count();

            var len = System.Math.Max(lengthofA, lengthofb);

            int count = 0;
            int i = 0;

            //bruit force
           // coverpoint_bruitforceApproach(A, B, lengthofA, ref count, ref i);

            while (i < len - 1)
            {
                int distanceA = 0;
                int distanceB = 0;

                if (i < lengthofA - 1)
                    distanceA = System.Math.Abs(A[i] - A[i + 1]);
                if (i < lengthofb - 1)
                    distanceB = System.Math.Abs(B[i] - B[i + 1]);
                count += Math.Max(distanceA, distanceB);

                i++;
            }

            return count;
        }

        private static void coverpoint_bruitforceApproach(List<int> A, List<int> B, int lengthofA, ref int count, ref int i)
        {
            while (i < lengthofA - 1)
            {
                while (A[i] != A[i + 1] || B[i] != B[i + 1])
                {
                    while (A[i] > A[i + 1] && B[i] > B[i + 1])
                    {
                        A[i] = A[i] - 1;
                        B[i] = B[i] - 1;

                        //(x, y) to (x-1, y - 1)
                        count++;
                    }

                    while (A[i] > A[i + 1] && B[i] == B[i + 1])
                    {
                        A[i] = A[i] - 1;
                        //(x-1, y)  
                        count++;
                    }


                    while (A[i] > A[i + 1] && B[i] < B[i + 1])
                    {
                        A[i] = A[i] - 1;
                        B[i] = B[i] + 1;
                        // (x-1, y+1), 
                        count++;
                    }

                    while (A[i] == A[i + 1] && B[i] > B[i + 1])
                    {
                        B[i] = B[i] - 1;
                        //(x  , y-1),
                        count++;
                    }

                    while (A[i] == A[i + 1] && B[i] < B[i + 1])
                    {
                        B[i] = B[i] + 1;
                        //(x, y + 1)
                        count++;
                    }


                    while (A[i] < A[i + 1] && B[i] > B[i + 1])
                    {
                        A[i] = A[i] + 1;
                        B[i] = B[i] - 1;
                        //(x + 1, y - 1), 
                        count++;
                    }

                    while (A[i] < A[i + 1] && B[i] == B[i + 1])
                    {
                        A[i] = A[i] + 1;
                        // (x+1, y)  , 
                        count++;
                    }


                    while (A[i] < A[i + 1] && B[i] < B[i + 1])
                    {
                        A[i] = A[i] + 1;
                        B[i] = B[i] + 1;
                        // (x+1, y)  , 
                        count++;
                    }

                }

                i++;
            }
        }
    }
}

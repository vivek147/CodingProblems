using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin.BinarySearch
{
    public class SearchForARange
    {
        //public static void Main()
        //{
        //    List<int> a1 = new List<int> { 5, 7, 7, 8, 9, 10 }; //0,1,2,3

        //    var result = SearchForARangeSolve(a1, 8);
        //}

        private static List<int> SearchForARangeSolve(List<int> A, int B)
        {
            
           
            
            List<int> ans = new List<int> { -1, -1 };

            if (A.Count == 1 && A[0] == B)
                return new List<int> { 0, 0 };

            int start = 0;
            int end = A.Count-1;

            while(start <=  end)
            {
                int mid = start + (end - start) / 2;

                if(A[mid] == B)
                {
                    int a = mid-1;
                  
                    while (a >= 0 && A[a] == B)
                    {
                        a = a - 1;
                    }

                    a = a + 1;

                    int b = mid + 1;

                    while (b <= A.Count-1 && A[b] == B)
                    {
                        b = b + 1;
                    }

                    b = b - 1;

                    return new List<int> { a, b };
                }

                if (A[mid] > B)
                    end = mid - 1;

                if (A[mid] < B)
                    start = mid + 1;

            }

            return ans;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin.BinarySearch
{
    public class WoodCutting_Made_Easy
    {

        //public static void Main()
        //{
        //    List<int> a1 = new List<int> { 117, 84, 50, 119, 74, 128 }; //0,1,2,3

        //    var result = WoodCutting_Made_EasySolve(a1, 58);
        //}

        private static int WoodCutting_Made_EasySolve(List<int> A, int B)
        {
            int ans = 0;
            int max = 0;
            
            for(int i=0;i<A.Count;i++)
            {
                if (max < A[i])
                    max = A[i];
            }

     
            int start = 0;

            while(start <= max)
            {
                int mid = start + (max - start) / 2;

               int accquiredWoodHeight = getAccquiredHeightForWood(A, mid);

                if (accquiredWoodHeight == B || start == mid) 
                    return mid;

                if (accquiredWoodHeight < B)
                    max = mid - 1;

                if (accquiredWoodHeight > B)
                    start = mid + 1;
            }



            return ans;
        }

        private static int getAccquiredHeightForWood(List<int> a, int mid)
        {
            int accquiredHeight = 0;
            for(int i=0;i<a.Count();i++)
            {
                if (a[i] > mid)
                    accquiredHeight += a[i] - mid;

            }

            return accquiredHeight;
        }
    }
}

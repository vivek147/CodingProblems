using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class First_Missing_Integer
    {
      //  public static void Main()
        //{
        //    List<int> a1 = new List<int> { 1, 2, 0 }; //0,1,2,3
        //    List<int> a2 = new List<int> { 3, 4, -1, 1 };
        //    List<int> a3 = new List<int> { -8, -7, -6 };

        //    // var result = SetMatrixZerosSolve(new List<List<int>> { a1, a2, a3 });
        //    var result 
        //      = First_Missing_IntegerSolveOptmized(new List<int> { 1, 2, 3, 4, 5, 6 });
        //    result = First_Missing_IntegerSolveOptmized(a1);
        //    result = First_Missing_IntegerSolveOptmized(a2);
        //    result = First_Missing_IntegerSolveOptmized(a3);


        //}

        private static int First_Missing_IntegerSolveOptmized(List<int> list)
        {
            list.Sort();

            int length = list.Count();

            if(length==1)
            {
                return list[0] < 1 || list[0] > 1 ? 1 : 2;
            }

            if (list[length - 1] < 0)
                return 1;

            //if (list[length - 1] < length)
            //    return length;

            bool current = true;

            for (int i = 0; i < length - 1; i++)
            {
                if(list[i] > 0 && current == true && list[i]!=1)
                {
                    return 1;
                }

                if (list[i] > 0 && list[i + 1] - list[i] != 1)
                {
                    current = false;
                    return list[i] + 1;
                }
                else if(list[i] > 0 && current == true && list[i] == 1)
                    current = false;
            }

            return list[length] + 1;
        }
    }
}

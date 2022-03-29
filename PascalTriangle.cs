using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class PascalTriangle
    {
        //public static void Main()
        //{
        //    int A = 5;
        //    var result = Solve(A);
        //}

        public static List<List<int>> Solve(int A)
        {
            List<List<int>> pascleTringle = new List<List<int>>();

            for (int i = 0; i < A; i++)
            {
                List<int> res = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        res.Add(1);
                    }
                    else
                    {
                        res.Add(pascleTringle[i - 1][j - 1] + pascleTringle[i - 1][j]);
                    }

                }
                pascleTringle.Add(res);
            }

            return pascleTringle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class SetMatrixZeros
    {
        //public static void Main()
        //{
        //    List<int> a1 = new List<int> { 1, 0, 1 }; //0,1,2,3
        //    List<int> a2 = new List<int> { 1, 1, 1 };
        //    List<int> a3 = new List<int> { 1, 0, 1 };

        //    // var result = SetMatrixZerosSolve(new List<List<int>> { a1, a2, a3 });
        //    var result = SetMatrixZerosSolveOptmized(new List<List<int>> { a1, a2, a3 });

        //}

        private static List<List<int>> SetMatrixZerosSolveOptmized(List<List<int>> list)
        {
            List<bool> columsMarked = new List<bool>();
            List<bool> rowsMarked = new List<bool>();

            for (int i = 0; i < list.Count(); i++)
            {
                rowsMarked.Add(false);
            }

            for (int i = 0; i < list[0].Count(); i++)
            {
                columsMarked.Add(false);
            }


            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j] == 0)
                    {
                        rowsMarked[i] = true;
                        columsMarked[j] = true;
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (rowsMarked[i]== true || columsMarked[j] == true)
                    {
                        list[i][j] = 0;
                    }
                }
            }

           return list;



           
        }

        public static List<List<int>> SetMatrixZerosSolve(List<List<int>> A)
        {

            List<int> i_exclustion = new List<int>();
            List<int> j_exclustion = new List<int>();
            int idetifier = -1;

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[i].Count; j++)
                {
                    if (A[i][j] == 0)
                    {
                        if (!i_exclustion.Contains(i))
                        {
                            for (int k = 0; k < A[i].Count; k++)
                            {
                                if (A[i][k] != 0)
                                    A[i][k] = idetifier; // set temprary as -1
                            }
                            i_exclustion.Add(i);
                        }

                        if (!j_exclustion.Contains(j))
                        {
                            for (int k = 0; k < A.Count; k++)
                            {
                                if (A[k][j] != 0)
                                    A[k][j] = idetifier; // set temprary as -1
                            }
                            j_exclustion.Add(j);
                        }
                    }
                }
            }


            //replace -1 with 0 and retrun as answer

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[i].Count; j++)
                {
                    if (A[i][j] == idetifier)
                    {
                        A[i][j] = 0;
                    }
                }
            }


            return A;
        }
    }
}
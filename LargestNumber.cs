using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class LargestNumber
    {
        //public static void Main()
        //{

        //    List<int> input = new List<int> { 3, 30, 34, 5, 9 };
        //    // var result = SolveLargestNumber(input);


        //   var res =   SolveLargestNumber1(input);

        //}

        private static string SolveLargestNumber1(List<int> input)
        {
           // input.Sort((a, b) => b.CompareTo(a));
            input.Sort((a, b) =>
            {
                var ab = Convert.ToInt64(a.ToString() + b.ToString());
                var ba = Convert.ToInt64(b.ToString() + a.ToString());

                if (ab > ba)
                    return 1;
                if (ab < ba)
                    return -1;

                return 0;
            });
          

            string outp = null;

            if (input.Count == 0 || input[0] == 0)
            {
                outp = "0";
            }
            else
            {
                input.Reverse();
                outp = string.Join("", input.Select(s => s));
                //for (int i = input.Count() - 1; i >= 0; i--)
                //{
                //    outp += input[i];
                //}
            }

            return outp;
        }

        static string SolveLargestNumber(List<int> arr)
        {
            string output = string.Empty;
            bool isAllzeos = true;

            if (arr.Count() == 1)
                return arr[0].ToString();

            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = i + 1; j < arr.Count(); j++)
                {
                    string ij = arr[i].ToString() + arr[j].ToString();
                    string ji = arr[j].ToString() + arr[i].ToString();

                    if (Convert.ToInt64(ij) < Convert.ToInt64(ji))
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

                if (arr[i] != 0)
                    isAllzeos = false;

                output += arr[i];
            }


            if (isAllzeos)
                return "0";
            else
                return output;
        }
    }
}

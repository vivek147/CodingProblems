using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class BreakPalendrome
    {

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    //var res = NumSubarrayBoundedMax(new int[] { 2,2,2,2,2,2,2,2,2,2,2,2 }, 1, 2);
        //    var res = BreakPalindrome("abccba");
        //    //fun(new List<int> { 5, 4, 2, 1, 3 });
        //    //fun(new List<int> { 2, 1, 3 });
        //    //fun(new List<int> { 4, 3, 5, 4, 3 });

        //    Console.ReadKey();
        //}
        public static string BreakPalindrome(string palindrome)
        {

            //   "abccba"; => "zbccba" => "aaccba";
            //    aaazaaa =>  baazaaa => aaazaab

            int length = palindrome.Length;
            int start = 0;

            if (length == 1)
                return palindrome;

            while (start < length / 2)
            {
                if (palindrome[start] != 'a')
                {
                    StringBuilder sb = new StringBuilder(palindrome);
                    sb[start] = 'a';
                    return sb.ToString();
                }
                start++;
            }

            StringBuilder sba = new StringBuilder(palindrome);
            sba[length - 1] = 'b';
            return sba.ToString();
        }


    }


    
}

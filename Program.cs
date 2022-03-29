using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    using System;

    namespace CoinTestApp
    {
        class Program
        {
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Hello World!");
            //    var output = findMin(5, 3, 31);

            //    if (output != null && output.Any())
            //    {
            //        Console.WriteLine(output[0]);
            //        Console.Write(output[1]);
            //    }

            //    Console.ReadKey();
            //}


            public static List<int> findMin(int bigCoin, int smallCoin, int amount , int numberofmaxBigCoins = 0 , int numberOfSmallCoins = 0 )
            {
                //1. 5 ,5  = 25
                //2. 3, 2 =  6

                //49  3,5
                //5,8 =  40  
                //3,3

                List<int> Coins = null;
                numberofmaxBigCoins = numberofmaxBigCoins > 0 ? numberofmaxBigCoins : amount / bigCoin ;
               // numberOfSmallCoins = numberOfSmallCoins > 0 ? numberOfSmallCoins : 0;
               
                int currAmt = numberofmaxBigCoins * bigCoin;
                if (amount > currAmt)
                {
                    numberOfSmallCoins = numberOfSmallCoins + 1;
                    var amt = currAmt + (smallCoin * numberOfSmallCoins);

                    if (amt == amount)
                    {
                        //print numberofmaxBigCoins , numberOfSmallCoinsr
                        return Coins =  new List<int> { numberofmaxBigCoins, numberOfSmallCoins };
                    }
                    else
                    {
                      var output =  findMin(bigCoin, smallCoin, amount, numberofmaxBigCoins - 1, numberOfSmallCoins);

                      Coins =  output !=null ? output : Coins;
                    }
                }

                return Coins;

                //for(int i = 0; i<= numberofBigCoins; i++)
                //{

                //}

            }




        }
    }
}


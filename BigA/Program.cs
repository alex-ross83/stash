using Common;
using System;
namespace BigA
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Given an int array of stock movement dates(index) and values,
            ///determine the couple that provides the max profit for buy/sell timing
            var input = new int[] { 4, 56, 84, 21, 42, 2, 78, 83 };
            string.Format("Input Array:[{0}]", string.Join(", ", input)).Dump();
            GetBestBuySellDates(input);
        }
        static void GetBestBuySellDates(int[] input)
        {
            var maxDiff = 0;
            var maxDiff_bestBuyDate = -1;
            var maxDiff_bestSellDate = -1;
            var numberOfComparisons = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length - 1 == i)
                {
                    //this is the last index of the array
                    break;
                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] - input[i] > maxDiff)
                    {
                        maxDiff = input[j] - input[i];
                        maxDiff_bestBuyDate = i;
                        maxDiff_bestSellDate = j;
                    }
                    numberOfComparisons++;
                }
            }
            string.Format("Best Buy Date:{0}", maxDiff_bestBuyDate).Dump();
            string.Format("Best Sell Date:{0}", maxDiff_bestSellDate).Dump();
            string.Format("Best profit: {0}", maxDiff).Dump();
            string.Format("Number of Comparisons: {0}", numberOfComparisons).Dump();
            Console.ReadLine();
        }
    }
}

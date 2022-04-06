using System.Linq;

namespace TheThinkingTraveller_SumOfEvenNumbers.DataProcessing
{
    internal static class DataProcessor
    {
        internal static int SumAllEvenNumbers(int[] integerArray)
        {

            var resultList = (from n in integerArray where n % 2 == 0 select n).ToList();

            int sumOfEvenNumbers = resultList.Sum();

            return sumOfEvenNumbers;
        }
    }
}

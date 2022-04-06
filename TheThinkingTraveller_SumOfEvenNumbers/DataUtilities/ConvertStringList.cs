using System;
using System.Linq;

namespace TheThinkingTraveller_SumOfEvenNumbers.DataUtilities
{
    internal static class ConvertStringList
    {
        internal static int[] ConvertStringListToIntegerArray(string csvOfIntegers)
        {
            csvOfIntegers = csvOfIntegers.TrimEnd(','); //remove any trailing commas

            var integerArray = csvOfIntegers.Split(',').Select(Int32.Parse).ToArray();

            return integerArray;
        }
    }
}

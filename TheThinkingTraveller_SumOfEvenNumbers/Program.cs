using System;
using TheThinkingTraveller_SumOfEvenNumbers.DataUtilities;
using TheThinkingTraveller_SumOfEvenNumbers.DataProcessing;


namespace TheThinkingTraveller_SumOfEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a comma separated list of numbers");
            string numberList = Console.ReadLine();

            int[] integerArray = ConvertStringList.ConvertStringListToIntegerArray(numberList);

            int sum = DataProcessor.SumAllEvenNumbers(integerArray);

            Console.WriteLine("The sum of the even integers is: " + sum);

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}

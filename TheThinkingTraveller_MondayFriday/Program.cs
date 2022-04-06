using System;
using TheThinkingTraveller_MondayFriday.DataProcessing;
using TheThinkingTraveller_MondayFriday.DataUtilities;

namespace TheThinkingTraveller_MondayFriday
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a date using this format: 2 Dec 2021");
            string startDateInput = Console.ReadLine();
           
            Console.WriteLine("Enter a second date using this format: 2 Dec 2021");
            string endDateInput = Console.ReadLine();

            DateTime[] fridayAndMondayDates = DateProcessor.GetFridayAndMondayDates(startDateInput, endDateInput);

            string dates = ConvertData.ConvertDateTimeArrayToStringList(fridayAndMondayDates);
            
            Console.WriteLine("Mondays or Fridays occur on these dates : " + dates);

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}

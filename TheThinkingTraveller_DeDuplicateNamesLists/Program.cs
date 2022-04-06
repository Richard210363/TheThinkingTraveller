using System;
using TheThinkingTraveller_DeDuplicateNamesLists.DataProcessing;
using TheThinkingTraveller_DeDuplicateNamesLists.DataUtilities;

namespace TheThinkingTraveller_DeDuplicateNamesLists
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a comma separated list of names");
            string namesList01 = Console.ReadLine();
            string[] namesArray01 = ConvertData.ConvertStringListToStringArray(namesList01);

            Console.WriteLine("Enter a second comma separated list of names");
            string namesList02 = Console.ReadLine();
            string[] namesArray02 = ConvertData.ConvertStringListToStringArray(namesList02);

            string[] deDuplicatedNamesArray = DataProcessor.GetUniqueNames(namesArray01, namesArray02);

            string deDuplicatedNamesString = ConvertData.ConvertStringArrayToStringList(deDuplicatedNamesArray);
            
            Console.WriteLine("The deduplicated combined list of names is : " + deDuplicatedNamesString);

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}

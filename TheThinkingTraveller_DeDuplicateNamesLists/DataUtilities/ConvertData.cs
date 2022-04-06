using System;

namespace TheThinkingTraveller_DeDuplicateNamesLists.DataUtilities
{
    internal static class ConvertData

    {
        internal static string[] ConvertStringListToStringArray(string csvOfNames)
        {
            csvOfNames = csvOfNames.TrimEnd(','); //remove any trailing commas

            var namesArray = csvOfNames.Split(',');

            return namesArray;
        }

        internal static string ConvertStringArrayToStringList(string[] arrayOfNames)
        {
            var namesList = String.Join(",", arrayOfNames);

            return namesList;
        }
    }
}

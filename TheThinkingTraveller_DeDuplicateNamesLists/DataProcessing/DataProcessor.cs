using System.Linq;

namespace TheThinkingTraveller_DeDuplicateNamesLists.DataProcessing
{
    internal static class DataProcessor
    {
        internal static string[] GetUniqueNames(string[] namesArray01, string[] namesArray02)
        {
            var deDuplicatedNamesArray = namesArray01.Union(namesArray02).ToArray();

            return deDuplicatedNamesArray;
        }
    }
}

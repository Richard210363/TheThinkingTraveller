using System;

namespace TheThinkingTraveller_MondayFriday.DataUtilities
{
    internal static class ConvertData
    {
        internal static DateTime ConvertStringDateToDateTime(string stringDate)
        {
            var date  = DateTime.Parse(stringDate);

            return date;
        }

        internal static string ConvertDateTimeArrayToStringList(DateTime[] arrayOfDates)
        {
            string dates = "";

            foreach (DateTime date in arrayOfDates)
            {
                dates = dates + string.Format("{0:d MMM yyyy}", date) + ",";
            }

            return dates;
        }
    }
}

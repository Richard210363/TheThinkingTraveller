using System;
using System.Collections.Generic;
using TheThinkingTraveller_MondayFriday.DataUtilities;

namespace TheThinkingTraveller_MondayFriday.DataProcessing
{
    internal static class DateProcessor
    {
        internal static DateTime[] GetFridayAndMondayDates(string startDateInput, string endDateInput)
        {
            DateTime startDate = ConvertData.ConvertStringDateToDateTime(startDateInput);
            DateTime endDate = ConvertData.ConvertStringDateToDateTime(endDateInput);

            List<DateTime> fridayAndMondayDatesList =  new List<DateTime>() ;

            DateTime currentDate = endDate;

            while (startDate <= currentDate)
            {

                if (currentDate.DayOfWeek == DayOfWeek.Monday || currentDate.DayOfWeek == DayOfWeek.Friday)
                {
                    fridayAndMondayDatesList.Add(currentDate);
                }
                currentDate = currentDate.AddDays(-1);
            }

            DateTime[] fridayAndMondayDates = fridayAndMondayDatesList.ToArray();

            return fridayAndMondayDates;
        }
    }
}

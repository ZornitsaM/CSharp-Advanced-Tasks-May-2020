using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static double GetDifferenceInDaysBetweenTwoDates(string firstDate,string secondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);
            var result = Math.Abs((startDate - endDate).TotalDays);

            return result;
        }
    }
}

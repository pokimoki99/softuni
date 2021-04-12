using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierExercises
{
    public class DateModifier
    {
        public int GetDaysDifference(string startDateASString, string endDAteAsString)
        {
            DateTime startDate = DateTime.Parse(startDateASString);
            DateTime endDate = DateTime.Parse(endDAteAsString);
            int totalDays = (int)(Math.Abs((startDate - endDate).TotalDays));
            return totalDays;

        }
    }
}
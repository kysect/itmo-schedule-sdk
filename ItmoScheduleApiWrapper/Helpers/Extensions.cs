using System;
using ItmoScheduleApiWrapper.Types;

namespace ItmoScheduleApiWrapper.Helpers
{
    public static class Extensions
    {
        public static bool Compare(this DataWeekType first, DataWeekType second)
        {
            if (first == second)
                return true;
            if (first == DataWeekType.Both || second == DataWeekType.Both)
                return true;

            return false;
        }

        public static string ToRuString(this DataWeekType weekType)
        {
            switch (weekType)
            {
                case DataWeekType.Both:
                    return string.Empty;
                case DataWeekType.Even:
                    return "четная";
                case DataWeekType.Odd:
                    return "нечетная";
                default:
                    throw new ArgumentOutOfRangeException(nameof(weekType), weekType, null);
            }
        }

        /// <summary>
        /// Covert <see cref="System.DayOfWeek"/> to <see cref="DataDayType"/>
        /// </summary>
        public static DataDayType ConvertToItmoDayType(this DayOfWeek dayOfWeek)
        {
            var dayType = (int)dayOfWeek;
            int itmoDayType = dayType == 0 ? 6 : dayType - 1;
            return (DataDayType)itmoDayType;
        }
    }
}
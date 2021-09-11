using System;

namespace Kysect.ItmoScheduleSdk.Types
{
    public enum DataDayType
    {
        Monday = 0,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public static class DayOfWeekExtensions
    {
        /// <summary>
        /// Covert <see cref="System.DayOfWeek"/> to <see cref="DataDayType"/>
        /// </summary>
        public static DataDayType ConvertToItmoDayType(this DayOfWeek dayOfWeek)
        {
            var dayType = (int)dayOfWeek;
            int itmoDayType = dayType == 0 ? 6 : dayType - 1;
            return (DataDayType)itmoDayType;
        }
        
        public static string ToRuString(this DataDayType? dayType)
        {
            switch (dayType)
            {
                case DataDayType.Monday:
                    return "Понедельник";
                case DataDayType.Tuesday:
                    return "Вторник";
                case DataDayType.Wednesday:
                    return "Среда";
                case DataDayType.Thursday:
                    return "Четверг";
                case DataDayType.Friday:
                    return "Пятница";
                case DataDayType.Saturday:
                    return "Суббота";
                default:
                    throw new ArgumentOutOfRangeException(nameof(dayType), dayType, null);
            }
        }
    }
}
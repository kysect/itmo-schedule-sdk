using System;

namespace ItmoScheduleApiWrapper.Types
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
    }
}
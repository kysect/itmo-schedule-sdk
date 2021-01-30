using System;
using System.Collections.Generic;
using Kysect.ItmoScheduleSdk.Filters;
using Kysect.ItmoScheduleSdk.Models;
using Kysect.ItmoScheduleSdk.Types;

namespace Kysect.ItmoScheduleSdk.Helpers
{
    public static class DayScheduleRepository
    {
        public static List<ScheduleItemModel> GetTodaySchedule(this IEnumerable<ScheduleItemModel> scheduleItemList, DateConvertorService convertor)
        {
            return GetDaySchedule(scheduleItemList, DateTime.Now, convertor);
        }

        public static List<ScheduleItemModel> GetDaySchedule(this IEnumerable<ScheduleItemModel> scheduleItemList,
            DateTime dayTime,
            DateConvertorService convertor)
        {
            (DataDayType dayType, DataWeekType weekType) dayType = convertor.Convert(dayTime);
            return DayTypeScheduleFilter.FilterBy(scheduleItemList, dayType.weekType, dayType.dayType);
        }
    }
}
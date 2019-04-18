using System;
using System.Collections.Generic;
using ItmoScheduleApiWrapper.Filters;
using ItmoScheduleApiWrapper.Models;
using ItmoScheduleApiWrapper.Types;

namespace ItmoScheduleApiWrapper.Helpers
{
    public static class DayScheduleRepository
    {
        public static List<ScheduleItemModel> GetTodaySchedule(this IEnumerable<ScheduleItemModel> scheduleItemList, DateConvertorService convertor)
        {
            (DataDayType dayType, DataWeekType weekType) dayType = convertor.Convert(DateTime.Today);
            return DayTypeScheduleFilter.Filter(scheduleItemList, dayType.weekType, dayType.dayType);
        }
    }
}
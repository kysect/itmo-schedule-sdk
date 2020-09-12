using System.Collections.Generic;
using System.Linq;
using ItmoScheduleApiWrapper.Models;
using ItmoScheduleApiWrapper.Types;

namespace ItmoScheduleApiWrapper.Filters
{
    public static class DayTypeScheduleFilter
    {
        public static List<ScheduleItemModel> Filter(this IEnumerable<ScheduleItemModel> lessonList, DataWeekType weekType)
        {
            return lessonList
                .Where(lesson => lesson.DataWeek.Compare(weekType))
                .ToList();
        }

        public static List<ScheduleItemModel> Filter(this IEnumerable<ScheduleItemModel> lessonList, DataDayType dayType)
        {
            return lessonList
                .Where(lesson => lesson.DataDay == dayType)
                .ToList();
        }

        public static List<ScheduleItemModel> Filter(this IEnumerable<ScheduleItemModel> lessonList, DataWeekType weekType, DataDayType dayType)
        {
            return lessonList
                .Where(lesson => lesson.DataWeek.Compare(weekType) && lesson.DataDay == dayType)
                .ToList();
        }
    }
}
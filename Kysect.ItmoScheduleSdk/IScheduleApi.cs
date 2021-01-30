using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kysect.ItmoScheduleSdk.Filters;
using Kysect.ItmoScheduleSdk.Models;
using Kysect.ItmoScheduleSdk.Types;
using Refit;

namespace Kysect.ItmoScheduleSdk
{
    public interface IScheduleApi
    {
        [Get("/schedule_lesson_room")]
        Task<List<RoomModel>> GetRoomList();

        [Get("/schedule_lesson_group/{group}")]
        Task<GroupScheduleModel> GetGroupScheduleAsync(string group);

        /// <summary>
        /// Get all person from ISU. Max elements count - 100.
        /// </summary>
        /// <param name="offset">Elements to skip count</param>
        /// <returns></returns>
        [Get("/schedule_person")]
        Task<PersonListModel> GetPersonListAsync(int offset);


        /// <summary>
        /// Get schedule for person
        /// </summary>
        /// <param name="personId">Person id from ISU</param>
        /// <returns></returns>
        [Get("/schedule_lesson_person/{personId}")]
        Task<PersonScheduleModel> GetPersonScheduleAsync(int personId);
    }

    public static class ScheduleApiExtensions
    {
        public static List<ScheduleItemModel> GetGroupPackSchedule(this IScheduleApi api, List<string> groupList)
        {
            IEnumerable<ScheduleItemModel> GetGroupSchedule(string groupTitle) =>
                api
                    .GetGroupScheduleAsync(groupTitle)
                    .Result
                    .Schedule;

            List<ScheduleItemModel> groupsItems = groupList
                .AsParallel()
                .Select(GetGroupSchedule)
                .SelectMany(e => e)
                .ScheduleOrder()
                .ToList();

            return groupsItems;
        }

        public static List<ScheduleItemModel> GetPersonPackSchedule(this IScheduleApi api, List<int> personIdList)
        {
            IEnumerable<ScheduleItemModel> GetGroupSchedule(int personId) =>
                api
                    .GetPersonScheduleAsync(personId)
                    .Result
                    .Schedule;

            List<ScheduleItemModel> groupsItems = personIdList
                .AsParallel()
                .Select(GetGroupSchedule)
                .SelectMany(e => e)
                .ScheduleOrder()
                .ToList();

            return groupsItems;
        }

        public static IEnumerable<DayScheduleDescriptor> GroupElementsPerDay(List<ScheduleItemModel> items)
        {
            foreach (DataWeekType weekType in Enum.GetValues(typeof(DataWeekType)).Cast<DataWeekType>())
            {
                foreach (DataDayType dayType in Enum.GetValues(typeof(DataDayType)).Cast<DataDayType>())
                {
                    List<ScheduleItemModel> dayItems = items
                        .FilterBy(weekType, dayType)
                        .ToList();

                    yield return new DayScheduleDescriptor(dayType, weekType, dayItems);
                }
            }
        }
    }
}
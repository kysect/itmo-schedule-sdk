using System.Collections.Generic;
using System.Threading.Tasks;
using ItmoScheduleApiWrapper.Models;
using Refit;

namespace ItmoScheduleApiWrapper
{
    public interface IScheduleApi
    {
        [Get("/schedule_lesson_room")]
        Task<List<RoomModel>> GetRoomList();

        [Get("/schedule_lesson_group/{group}")]
        Task<GroupScheduleModel> GetGroupSchedule(string group);

        /// <summary>
        /// Get all person from ISU. Max elements count - 100.
        /// </summary>
        /// <param name="offset">Elements to skip count</param>
        /// <returns></returns>
        [Get("/schedule_person")]
        Task<PersonListModel> GetPersonList(int offset);


        /// <summary>
        /// Get schedule for person
        /// </summary>
        /// <param name="personId">Person id from ISU</param>
        /// <returns></returns>
        [Get("/schedule_lesson_person/{personId}")]
        Task<PersonScheduleModel> GetPersonSchedule(int personId);
    }
}
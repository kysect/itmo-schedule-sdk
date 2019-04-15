using System.Collections.Generic;
using System.Threading.Tasks;
using DeItmoApiWrapper.Models;
using Refit;

namespace DeItmoApiWrapper
{
    public interface IScheduleApi
    {
        [Get("/schedule_lesson_room")]
        Task<List<RoomModel>> GetRoomList();

        [Get("/schedule_lesson_group/{group}")]
        Task<GroupScheduleModel> GetGroupSchedule(string group);

        [Get("/schedule_person")]
        Task<PersonListModel> GetPersonList(int offset);

        [Get("/schedule_lesson_person/{personId}")]
        Task<PersonScheduleModel> GetPersonSchedule(int personId);
    }
}
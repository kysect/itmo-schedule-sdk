using System.Collections.Generic;
using System.Threading.Tasks;
using DeItmoApiWrapper.Models;
using Refit;

namespace DeItmoApiWrapper
{
    public interface IScheduleApi
    {
        [Get("/schedule_lesson_room")]
        Task<List<RoomModel>> GetLessonRoomList();

        [Get("/schedule_lesson_group/{group}")]
        Task<GroupScheduleModel> GetLessonGroupSchedule(string group);
    }
}
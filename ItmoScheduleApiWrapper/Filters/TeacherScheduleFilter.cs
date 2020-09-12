using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItmoScheduleApiWrapper.Models;

namespace ItmoScheduleApiWrapper.Filters
{
    public class TeacherScheduleFilter
    {
        public async Task<List<ScheduleItemModel>> GetScheduleForGroups(int personId, params string[] groups)
        {
            PersonScheduleModel teacherSchedule = await ItmoApiProvider.Instance.GetPersonScheduleAsync(personId);

            return teacherSchedule.Schedule
                .Where(lesson => groups.Contains(lesson.Group))
                .ToList();
        }

        public async Task<List<ScheduleItemModel>> GetScheduleForSubjectName(int personId, string subjectTitle)
        {
            PersonScheduleModel teacherSchedule = await ItmoApiProvider.Instance.GetPersonScheduleAsync(personId);

            return teacherSchedule.Schedule
                .Where(lesson => lesson.SubjectTitle.Equals(subjectTitle))
                .ToList();
        }
    }
}
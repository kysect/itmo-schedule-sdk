using System.Collections.Generic;
using System.Linq;
using Kysect.ItmoScheduleSdk.Types;
using Newtonsoft.Json;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class ScheduleItemModel
    {
        [JsonProperty(PropertyName = "data_day")]
        public DataDayType? DataDay { get; set; }

        public string Status { get; set; }

        [JsonProperty(PropertyName = "data_week")]
        public DataWeekType DataWeek { get; set; }

        [JsonProperty(PropertyName = "gr")]
        public string Group { get; set; }

        [JsonProperty(PropertyName = "subj_time")]
        public string SubjectTime { get; set; }

        public int Sortp { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string SubjectTitle { get; set; }
        public string Note { get; set; }

        [JsonProperty(PropertyName = "person")]
        public string Teacher { get; set; }

        public int? Pid { get; set; }

        [JsonProperty(PropertyName = "bld_id")]
        public int? BldId { get; set; }

        [JsonProperty(PropertyName = "cathedra_bun_id")]
        public int? CathedraBunId { get; set; }

        [JsonProperty(PropertyName = "faculty_bun_id")]
        public int? FacultyBunId { get; set; }

        public int Course { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public string StartTime { get; set; }

        [JsonProperty(PropertyName = "end_time")]
        public string EndTime { get; set; }

        public bool IsLecture()
        {
            return Status == "Лек";
        }

        public string ShortSubjectTitle()
        {
            return (IsLecture() ? "[П]" : "[Л]") + " " + SubjectTitle;
        }

        public string ShortTeacherName()
        {
            if (string.IsNullOrEmpty(Teacher))
                return Teacher;

            string[] parts = Teacher.Split(' ');
            for (var i = 1; i < parts.Length; i++)
                parts[i] = $"{parts[i][0]}.";

            return string.Join(" ", parts);
        }
    }

    public static class ScheduleItemModelExtensions
    {
        public static IEnumerable<ScheduleItemModel> ScheduleOrder(this IEnumerable<ScheduleItemModel> scheduleItems)
        {
            return scheduleItems
                .OrderBy(e => e.StartTime)
                .ThenBy(e => e.SubjectTitle)
                .ThenBy(e => e.Group)
                .ThenBy(e => e.Teacher);
        }
    }
}
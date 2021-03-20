using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Kysect.ItmoScheduleSdk.Types;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class ScheduleItemModel
    {
        [JsonPropertyName("data_day")]
        public DataDayType? DataDay { get; set; }

        public string Status { get; set; }

        [JsonPropertyName("data_week")]
        public DataWeekType DataWeek { get; set; }

        [JsonPropertyName("gr")]
        public string Group { get; set; }

        [JsonPropertyName("subj_time")]
        public string SubjectTime { get; set; }

        public int Sortp { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
        [JsonPropertyName("title")]
        public string SubjectTitle { get; set; }
        public string Note { get; set; }

        [JsonPropertyName("person")]
        public string Teacher { get; set; }

        public int? Pid { get; set; }

        [JsonPropertyName("bld_id")]
        public int? BldId { get; set; }

        [JsonPropertyName("cathedra_bun_id")]
        public int? CathedraBunId { get; set; }

        [JsonPropertyName("faculty_bun_id")]
        public int? FacultyBunId { get; set; }

        public int Course { get; set; }

        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        [JsonPropertyName("end_time")]
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
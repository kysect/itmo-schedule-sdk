using ItmoScheduleApiWrapper.Types;
using Newtonsoft.Json;

namespace ItmoScheduleApiWrapper.Models
{
    public class ScheduleItemModel
    {
        [JsonProperty(PropertyName = "data_day")]
        public DataDayType DataDay { get; set; }

        public string Status { get; set; }

        [JsonProperty(PropertyName = "data_week")]
        public DataWeekType DataWeek { get; set; }

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
    }
}
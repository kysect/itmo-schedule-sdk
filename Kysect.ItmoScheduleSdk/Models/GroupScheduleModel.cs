using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class GroupScheduleModel
    {
        public string Query { get; set; }
        public string Label { get; set; }

        [JsonPropertyName("type_title")]
        public string TypeTitle { get; set; }

        public string Today { get; set; }

        [JsonPropertyName("today_data_day")]
        public string TodayDataDay { get; set; }

        [JsonPropertyName("week_type")]
        public string WeekType { get; set; }

        [JsonPropertyName("data_day")]
        public string DataDay { get; set; }

        [JsonPropertyName("current_week")]
        public string CurrentWeek { get; set; }

        public List<ScheduleItemModel> Schedule { get; set; }
    }
}
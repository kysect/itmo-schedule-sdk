using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class RoomScheduleModel
    {
        public string Query { get; set; }
        public string Label { get; set; }
        
        [JsonPropertyName("type_title")]
        public string TypeTitle { get; set; }

        public string Today { get; set; }

        [JsonPropertyName("today_data_day")]
        public int TodayDataDay { get; set; }
        
        [JsonPropertyName("current_week")]
        public int CurrentWeek { get; set; }
        
        public List<ScheduleItemModel> Schedule { get; set; }
    }
}
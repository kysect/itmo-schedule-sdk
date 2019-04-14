using System.Collections.Generic;
using Newtonsoft.Json;

namespace DeItmoApiWrapper.Models
{
    public class GroupScheduleModel
    {
        public string Query { get; set; }
        public string Label { get; set; }
        [JsonProperty(PropertyName = "type_title")]
        public string TypeTitle { get; set; }
        public string Today { get; set; }
        [JsonProperty(PropertyName = "today_data_day")]
        public string TodayDataDay { get; set; }
        [JsonProperty(PropertyName = "week_type")]
        public string WeekType { get; set; }
        [JsonProperty(PropertyName = "data_day")]
        public string DataDay { get; set; }
        [JsonProperty(PropertyName = "current_week")]
        public string CurrentWeek { get; set; }
        public List<GroupScheduleItemModel> Schedule { get; set; }
    }
}
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class PersonScheduleModel
    {
        public string Query { get; set; }

        [JsonPropertyName("Label")] public string PersonName { get; set; }

        [JsonPropertyName("type_title")]
        public string TypeTitle { get; set; }

        public int Pid { get; set; }
        public string Today { get; set; }

        [JsonPropertyName("current_week")]
        public string CurrentWeek { get; set; }

        public List<ScheduleItemModel> Schedule { get; set; }
    }
}
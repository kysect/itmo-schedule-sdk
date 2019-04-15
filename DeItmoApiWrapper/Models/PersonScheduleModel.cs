using System.Collections.Generic;
using Newtonsoft.Json;

namespace DeItmoApiWrapper.Models
{
    public class PersonScheduleModel
    {
        public string Query { get; set; }

        [JsonProperty(PropertyName = "Label")] public string PersonName { get; set; }

        [JsonProperty(PropertyName = "type_title")]
        public string TypeTitle { get; set; }

        public int Pid { get; set; }
        public string Today { get; set; }

        [JsonProperty(PropertyName = "current_week")]
        public string CurrentWeek { get; set; }

        public List<ScheduleItemModel> Schedule { get; set; }
    }
}
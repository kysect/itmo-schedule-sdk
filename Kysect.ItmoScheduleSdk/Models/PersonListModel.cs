using System.Collections.Generic;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class PersonListModel
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public List<PersonListItemModel> List { get; set; }
    }
}
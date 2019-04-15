﻿using System.Collections.Generic;

namespace DeItmoApiWrapper.Models
{
    public class PersonListModel
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public List<PersonListItemModel> List { get; set; }
    }
}
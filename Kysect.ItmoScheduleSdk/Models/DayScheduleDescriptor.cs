﻿using System.Collections.Generic;
using Kysect.ItmoScheduleSdk.Types;

namespace Kysect.ItmoScheduleSdk.Models
{
    public class DayScheduleDescriptor
    {
        public DataDayType DataDay { get; set; }
        public DataWeekType DataWeek { get; set; }

        public List<ScheduleItemModel> ScheduleItems { get; set; }

        public DayScheduleDescriptor(DataDayType dataDay, DataWeekType dataWeek, List<ScheduleItemModel> scheduleItems)
        {
            DataDay = dataDay;
            DataWeek = dataWeek;
            ScheduleItems = scheduleItems;
        }
    }
}
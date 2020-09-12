﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItmoScheduleApiWrapper.Helpers;
using ItmoScheduleApiWrapper.Models;

namespace ItmoScheduleApiWrapper.Samples
{
    internal class Program
    {
        private static void Main()
        {
            var provider = new ItmoApiProvider();

            Task<GroupScheduleModel> task = provider.ScheduleApi.GetGroupScheduleAsync("M3305");
            List<ScheduleItemModel> lessonList = task.Result.Schedule;

            foreach (ScheduleItemModel itemModel in lessonList)
            {
                Console.WriteLine(itemModel.SubjectTitle);
            }

            Task<PersonListModel> personList = provider.ScheduleApi.GetPersonListAsync(10);
            Console.WriteLine(personList.Result.Offset);
            foreach (PersonListItemModel person in personList.Result.List.Take(5))
            {
                Console.WriteLine(person.Person);
            }

            Task<PersonScheduleModel> personSchedule = provider.ScheduleApi.GetPersonScheduleAsync(116501);
            Console.WriteLine(personSchedule.Result.PersonName);
            foreach (ScheduleItemModel itemModel in personSchedule.Result.Schedule)
            {
                Console.WriteLine(itemModel.SubjectTitle);
            }

            List<ScheduleItemModel> todaySchedule = provider.ScheduleApi
                .GetGroupScheduleAsync("M3305")
                .Result
                .Schedule
                .GetTodaySchedule(DateConvertorService.FirstWeekEven);

            foreach (ScheduleItemModel itemModel in todaySchedule)
            {
                Console.WriteLine(itemModel.SubjectTitle);
            }
        }
    }
}
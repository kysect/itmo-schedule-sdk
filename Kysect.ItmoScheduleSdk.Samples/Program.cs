using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kysect.ItmoScheduleSdk.Helpers;
using Kysect.ItmoScheduleSdk.Models;

namespace Kysect.ItmoScheduleSdk.Samples
{
    internal class Program
    {
        private static async Task Main()
        {
            var provider = new ItmoApiProvider();

            GroupScheduleModel task = await provider.ScheduleApi.GetGroupScheduleAsync("M32011");
            List<ScheduleItemModel> lessonList = task.Schedule;

            foreach (ScheduleItemModel itemModel in lessonList)
            {
                Console.WriteLine(itemModel.SubjectTitle);
            }

            //TODO: check. Endless loading
            //PersonListModel personList = await provider.ScheduleApi.GetPersonListAsync(10);
            //Console.WriteLine(personList.Offset);
            //foreach (PersonListItemModel person in personList.List.Take(5))
            //{
            //    Console.WriteLine(person.Person);
            //}

            PersonScheduleModel personSchedule = await provider.ScheduleApi.GetPersonScheduleAsync(116501);
            Console.WriteLine(personSchedule.PersonName);
            foreach (ScheduleItemModel itemModel in personSchedule.Schedule)
            {
                Console.WriteLine(itemModel.SubjectTitle);
            }

            List<ScheduleItemModel> todaySchedule = (await provider.ScheduleApi
                .GetGroupScheduleAsync("M3201"))
                .Schedule
                .GetTodaySchedule(DateConvertorService.FirstWeekEven);

            foreach (ScheduleItemModel itemModel in todaySchedule)
            {
                Console.WriteLine(itemModel.SubjectTitle);
            }
        }
    }
}
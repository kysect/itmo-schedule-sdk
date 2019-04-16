using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItmoScheduleApiWrapper.Models;

namespace ItmoScheduleApiWrapper.Samples
{
    internal class Program
    {
        private static void Main()
        {
            var provider = new ItmoApiProvider();
            Task<GroupScheduleModel> task = provider.ScheduleApi.GetGroupSchedule("M3305");
            List<ScheduleItemModel> lessonList = task.Result.Schedule;

            foreach (ScheduleItemModel itemModel in lessonList)
            {
                Console.WriteLine(itemModel.Title);
            }

            Task<PersonListModel> personList = provider.ScheduleApi.GetPersonList(10);
            Console.WriteLine(personList.Result.Offset);
            foreach (PersonListItemModel person in personList.Result.List.Take(5))
            {
                Console.WriteLine(person.Person);
            }

            Task<PersonScheduleModel> personSchedule = provider.ScheduleApi.GetPersonSchedule(116501);
            Console.WriteLine(personSchedule.Result.PersonName);
            foreach (ScheduleItemModel itemModel in personSchedule.Result.Schedule)
            {
                Console.WriteLine(itemModel.Title);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DeItmoApiWrapper;
using DeItmoApiWrapper.Models;

namespace DeItmpApiWrapper.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new DeItmoApiProvider();
            Task<GroupScheduleModel> task = provider.ScheduleApi.GetGroupSchedule("M3305");
            List<GroupScheduleItemModel> lessonList = task.Result.Schedule;

            foreach (GroupScheduleItemModel itemModel in lessonList)
            {
                Console.WriteLine(itemModel.Title);
            }

            Task<PersonListModel> personList = provider.ScheduleApi.GetPersonList(10);
            Console.WriteLine(personList.Result.Offset);
            foreach (PersonListItemModel person in personList.Result.List)
            {
                Console.WriteLine(person.Person);
            }
        }
    }
}

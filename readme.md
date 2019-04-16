# ITMO schedule api wrapper

<a href="https://docs.microsoft.com/en-us/dotnet/standard/net-standard"><img src="https://img.shields.io/badge/.NET%20Standard-2.0-green.svg"></a>

Библиотека для работы с API ИТМО написанное под C#.

## Примеры

Получение расписания группы:
```cs
var provider = new ItmoApiProvider();
Task<GroupScheduleModel> task = provider.ScheduleApi.GetGroupSchedule("group_title");
List<ScheduleItemModel> lessonList = task.Result.Schedule;
foreach (ScheduleItemModel itemModel in lessonList)
{
    Console.WriteLine(itemModel.Title);
}
```

Получение расписания преподавателя:
```cs
var provider = new ItmoApiProvider();
Task<PersonScheduleModel> personSchedule = provider.ScheduleApi.GetPersonSchedule(116501);
Console.WriteLine(personSchedule.Result.PersonName);
foreach (ScheduleItemModel itemModel personSchedule.Result.Schedule)
{
    Console.WriteLine(itemModel.Title);
}
```

## Использованные технологии
- .NET Standard 2.0
- [Refit 4.6.107](https://github.com/reactiveui/refit)

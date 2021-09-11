# ITMO schedule sdk

<a href="https://docs.microsoft.com/en-us/dotnet/standard/net-standard"><img src="https://img.shields.io/badge/.NET%20Standard-2.1-green.svg"></a>
[![Nuget](https://img.shields.io/nuget/v/Kysect.ItmoScheduleSdk?style=flat-square)](https://www.nuget.org/packages/Kysect.ItmoScheduleSdk/)

Библиотека для работы с API ИТМО.

## Install

```
Install-Package Kysect.ItmoScheduleSdk -Version 1.0.4
```

## Примеры

Получение расписания группы:
```cs
var provider = new ItmoApiProvider();
GroupScheduleModel task = await provider.ScheduleApi.GetGroupScheduleAsync("group_title");
foreach (ScheduleItemModel itemModel in task.Schedule)
{
    Console.WriteLine(itemModel.Title);
}
```

Получение расписания преподавателя:
```cs
var provider = new ItmoApiProvider();
PersonScheduleModel personSchedule = await provider.ScheduleApi.GetPersonScheduleAsync(116501);
Console.WriteLine(personSchedule.PersonName);
foreach (ScheduleItemModel itemModel personSchedule.Schedule)
{
    Console.WriteLine(itemModel.Title);
}
```

Получение расписания аудитории:
```cs
var provider = new ItmoApiProvider();
RoomScheduleModel roomSchedule = await provider.ScheduleApi.GetRoomSchedule("103");
foreach (ScheduleItemModel itemModel roomSchedule.Schedule)
{
    Console.WriteLine(itemModel.Title);
}
```

## Использованные технологии
- .NET Standard 2.1
- [Refit 4.6.107](https://github.com/reactiveui/refit)

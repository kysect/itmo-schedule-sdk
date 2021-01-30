using Refit;

namespace Kysect.ItmoScheduleSdk
{
    public class ItmoApiProvider
    {
        private const string ApiUrl = "https://mountain.ifmo.ru/api.ifmo.ru/public/v1";

        public ItmoApiProvider()
        {
            ScheduleApi = RestService.For<IScheduleApi>(ApiUrl);
        }

        public IScheduleApi ScheduleApi { get; }

        public static IScheduleApi Instance { get; } = RestService.For<IScheduleApi>(ApiUrl);
    }
}
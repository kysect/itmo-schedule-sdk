using Refit;

namespace DeItmoApiWrapper
{
    public class DeItmoApiProvider
    {
        private const string ApiUrl = "https://mountain.ifmo.ru/api.ifmo.ru/public/v1";

        public DeItmoApiProvider()
        {
            ScheduleApi = RestService.For<IScheduleApi>(ApiUrl);
        }

        public IScheduleApi ScheduleApi { get; }
    }
}
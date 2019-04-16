using Refit;

namespace ItmoScheduleApiWrapper
{
    public class ItmoApiProvider
    {
        private const string ApiUrl = "https://mountain.ifmo.ru/api.ifmo.ru/public/v1";

        public ItmoApiProvider()
        {
            ScheduleApi = RestService.For<IScheduleApi>(ApiUrl);
        }

        /// <summary>
        /// API provider
        /// </summary>
        public IScheduleApi ScheduleApi { get; }
    }
}
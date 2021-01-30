using System;
using System.Globalization;
using Kysect.ItmoScheduleSdk.Types;

namespace Kysect.ItmoScheduleSdk.Helpers
{
    public class DateConvertorService
    {
        public static DateConvertorService FirstWeekEven = new DateConvertorService(true);
        public static DateConvertorService FirstWeekOdd = new DateConvertorService(false);

        private readonly bool _isFirstWeekEven;

        public DateConvertorService(bool isFirstWeekEven)
        {
            _isFirstWeekEven = isFirstWeekEven;
        }

        public (DataDayType dayType, DataWeekType weekType) Convert(DateTime dateTime)
        {
            DataDayType dayType = dateTime.DayOfWeek.ConvertToItmoDayType();

            int weekOfYear = CultureInfo
                .CurrentCulture
                .Calendar
                .GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            switch (_isFirstWeekEven)
            {
                case true when weekOfYear % 2 == 1:
                    return (dayType, DataWeekType.Even);
                case true when weekOfYear % 2 == 0:
                    return (dayType, DataWeekType.Odd);
                case false when weekOfYear % 2 == 1:
                    return (dayType, DataWeekType.Odd);
                case false when weekOfYear % 2 == 0:
                    return (dayType, DataWeekType.Even);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
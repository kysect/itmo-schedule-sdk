using System;

namespace Kysect.ItmoScheduleSdk.Types
{
    public enum DataWeekType
    {
        Both = 0,
        Even = 1,
        Odd = 2
    }

    public static class DataWeekTypeExtensions
    {
        public static bool Compare(this DataWeekType first, DataWeekType second)
        {
            if (first == second)
                return true;
            if (first == DataWeekType.Both || second == DataWeekType.Both)
                return true;

            return false;
        }

        public static string ToRuString(this DataWeekType weekType)
        {
            switch (weekType)
            {
                case DataWeekType.Both:
                    return "все";
                case DataWeekType.Even:
                    return "чётная";
                case DataWeekType.Odd:
                    return "нечётная";
                default:
                    throw new ArgumentOutOfRangeException(nameof(weekType), weekType, null);
            }
        }
    }
}
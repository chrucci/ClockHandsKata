using System;

namespace ClockHands
{
    public static class Clock
    {
        public static double GetAngle(int hour, int minute)
        {
            var degreesOfHourHand = GetHourAngle(hour, minute);
            var degreesOfMinuteHand = GetMinuteAngle(minute);
            var degrees = degreesOfHourHand - degreesOfMinuteHand;
            const int maxAllowedAngle = 180;
            if (degrees > maxAllowedAngle) degrees = maxAllowedAngle + (maxAllowedAngle - degrees);
            
            return Math.Abs(degrees);
        }

        private static double GetMinuteAngle(int minute)
        {
            const int degreesPerMinute = 6;
            return minute * degreesPerMinute;
        }

        private static double GetHourAngle(int hour, int minute)
        {
            if (hour == 12) return 0;
            const int degreesPerHour = 30;
            const double degreesPerMinute = 0.5;
            var degrees = (degreesPerHour * hour) + (degreesPerMinute * minute);
            return degrees;
        }
    }
}
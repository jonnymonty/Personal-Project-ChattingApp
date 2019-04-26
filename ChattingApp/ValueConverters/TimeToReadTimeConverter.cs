using System;
using System.Globalization;
using System.Windows;

namespace ChattingApp
{
    /// <summary>
    /// A converter that takes in a date and converts to a user friendly read time
    /// </summary>
    public class TimeToReadTimeConverter : BaseValueConverter<TimeToReadTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time passed in
            var time = (DateTimeOffset)value;

            // If it is not read...
            if (time == DateTimeOffset.MinValue)
                // Show nothing
                return string.Empty;

            // If it is today...
            if (time.Date == DateTimeOffset.UtcNow.Date)
                // Return just the time
                return $"Read {time.ToLocalTime().ToString("hh:mm tt")}";

            // Otherwise return a full date
            return $"Read {time.ToLocalTime().ToString("hh:mm tt, MMMM yyyy")}";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

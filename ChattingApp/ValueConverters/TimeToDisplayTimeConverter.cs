using System;
using System.Globalization;
using System.Windows;

namespace ChattingApp
{
    /// <summary>
    /// A converter that takes in a date and converts to a user friendly time
    /// </summary>
    public class TimeToDisplayTimeConverter : BaseValueConverter<TimeToDisplayTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time passed in
            var time = (DateTimeOffset)value;

            // If it is today...
            if (time.Date == DateTimeOffset.UtcNow.Date)
                // Return just the time
                return time.ToLocalTime().ToString("hh:mm tt");

            // Otherwise return a full date
            return time.ToLocalTime().ToString("hh:mm tt, MMMM yyyy");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

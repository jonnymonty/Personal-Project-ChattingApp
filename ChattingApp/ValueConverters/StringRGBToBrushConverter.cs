﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace ChattingApp
{
    /// <summary>
    /// A converter that takes in an RGB string and converts it to a wpf brush
    /// </summary>
    public class StringRGBToBrushConverter : BaseValueConverter<StringRGBToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{value}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

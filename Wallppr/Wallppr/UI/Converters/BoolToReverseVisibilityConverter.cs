﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Wallppr.UI.Converters
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BoolToReverseVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;
            return value != null && (bool)value ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

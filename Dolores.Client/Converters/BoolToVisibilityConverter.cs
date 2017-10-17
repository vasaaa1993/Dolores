using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Dolores.Client.Converters
{
    class BoolToVisibilityConverter : IValueConverter
    {
	    public static BoolToVisibilityConverter Instance = new BoolToVisibilityConverter();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	    {
			bool val = value != null && (bool)value;
		    return (val) ? Visibility.Visible : Visibility.Collapsed;
		}

	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
		    throw new NotImplementedException();
	    }
    }
}

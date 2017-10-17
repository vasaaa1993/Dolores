using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Dolores.Client.Converters
{
    class InverseBoolToVisibleConverter : IValueConverter
    {
	    public static InverseBoolToVisibleConverter Instance = new InverseBoolToVisibleConverter();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			bool val = value != null && (bool) value;
			return (val) ? Visibility.Collapsed : Visibility.Visible;

		}

	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
		    throw new NotImplementedException();
	    }
    }
}

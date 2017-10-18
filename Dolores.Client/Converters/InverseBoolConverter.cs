using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Dolores.Client.Converters
{
	class InverseBoolConverter : IValueConverter
	{
		public static InverseBoolConverter Instance = new InverseBoolConverter();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			bool val = value != null && (bool)value;
			return !val;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

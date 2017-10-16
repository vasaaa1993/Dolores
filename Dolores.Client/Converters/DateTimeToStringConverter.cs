using System;
using System.Globalization;
using System.Windows.Data;

namespace Dolores.Client.Converters
{
	[ValueConversion(typeof(DateTime), typeof(string))]
    class DateTimeToStringConverter:IValueConverter
    {
		public static DateTimeToStringConverter Instance = new DateTimeToStringConverter();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	    {
		    if (value != null)
		    {
			    DateTime time = (DateTime)value;
			    return time.ToString("yyyy MMMM dd");
		    }
		    return null;
	    }

	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
		    throw new NotImplementedException();
	    }
    }
}

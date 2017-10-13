using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Dolores.Client.Views.Common;

namespace Dolores.Client.Converters
{
	[ValueConversion(typeof(string), typeof(BitmapImage))]
    class HeaderToImageConverter: IValueConverter
    {
		public static HeaderToImageConverter Instance = new HeaderToImageConverter();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var path = (string) value;
			if (path == null)
				return null;
			string image;

			var name = SelectFolder.GetFileFolderName(path);

			if (string.IsNullOrEmpty(name)) // disk
			{
				image = "Images/disk.png";
	
			}
			else if(new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
			{
				image = "Images/folder.png";
			}
			else
			{
				image = "Images/file.png";
			}

			return new BitmapImage(new Uri($"pack://application:,,,/AppData/{image}"));
		}

	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
		    throw new NotImplementedException();
	    }
    }
}

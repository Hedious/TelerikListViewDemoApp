using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEditor
{
    public class ContinentalIdToTextConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            if (value == null)
                return "";

            var format = (DateTime)value;

            return format.ToString("MMMM yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

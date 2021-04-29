using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace WeatherTwentyOne.Converters
{
    public class TempSpanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // two values
            double minTemp = double.Parse(values[0].ToString());
            double maxTemp = double.Parse(values[1].ToString());

            var dif = maxTemp - minTemp;
            
            return (dif*3);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            if (!(value is bool b) || targetTypes.Any(t => !t.IsAssignableFrom(typeof(bool))))
            {
                // Return null to indicate conversion back is not possible
                return null;
            }

            if (b)
            {
                return targetTypes.Select(t => (object)true).ToArray();
            }
            else
            {
                // Can't convert back from false because of ambiguity
                return null;
            }
        }
    }
}

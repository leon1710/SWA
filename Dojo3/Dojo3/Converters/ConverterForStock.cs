using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Dojo3.Converters
{
    class ConverterForStock : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int tmp = (int)value;
            if (tmp < 10) { return new SolidColorBrush(Colors.Red); }
            else if (tmp < 20) { return new SolidColorBrush(Colors.Yellow); }
            else { return new SolidColorBrush(Colors.Green); }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}

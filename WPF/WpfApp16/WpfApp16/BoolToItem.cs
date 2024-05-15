using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using WpfApp16;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Drawing;
using System.Windows.Data;

namespace WpfApp16
{
    public class BoolToItem : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool temp = (bool)value;
                if (temp)
                {
                    return "Italic";
                }
                else
                {
                    return "Normal";
                }
            }
            return "Normal";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

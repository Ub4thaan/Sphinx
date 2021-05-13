using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Sphinx.ValueConverters
{
    class StringToDoubleConverter : IValueConverter
    {
        public string Format { get; set; } = "";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return Double.Parse((string)value);
            }
            catch (Exception ex) 
            {
                return 0;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is double)
            {
                return ((double)value).ToString(Format);
            }
            return "";
        }
    }
}

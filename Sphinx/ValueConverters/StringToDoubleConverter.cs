using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Sphinx.ValueConverters
{
    public class StringToDoubleConverter : IValueConverter
    {
        public string Format { get; set; } = "";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
            {
                return Format != String.Empty ? ((double)value).ToString(Format) : ((double)value).ToString();
            }
            return "";
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
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
    }
}

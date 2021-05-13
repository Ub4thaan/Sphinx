using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sphinx.ValidationRules
{
    public class DoubleRangeValidationRule : ValidationRule
    {
        public double Min { get; set; } = Double.MinValue;
        public double Max { get; set; } = Double.MaxValue;
        public bool IncludeExtremes { get; set; } = true;
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double number = 0;
            try
            {
                if (((string)value).Length > 0)
                {
                    number = Double.Parse((string)value);
                }
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, $"Illegal characters or {ex.Message}");
            }
            if (IncludeExtremes)
            {
                if (number < Min || number > Max)
                {
                    return new ValidationResult(false, $"Please enter a value in the range: {Min} - {Max}, excluding extremes");
                }
            }
            else
            {
                if (number <= Min || number >= Max)
                {
                    return new ValidationResult(false, $"Please enter a value in the range: {Min} - {Max}, excluding extremes");
                }
            }
            return ValidationResult.ValidResult;
        }
    }
}

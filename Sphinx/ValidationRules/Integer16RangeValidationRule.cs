using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sphinx.ValidationRules
{
    public class Integer16RangeValidationRule : ValidationRule
    {
        public Int16 Min { get; set; } = Int16.MinValue;
        public Int16 Max { get; set; } = Int16.MaxValue;
        public bool IncludeExtremes { get; set; } = true;
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Int16 number = 0;
            try
            {
                if (((string)value).Length > 0)
                {
                    number = Int16.Parse((string)value);
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
                    return new ValidationResult(false, $"Please enter a value in the range: {Min} - {Max}, including extremes");
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

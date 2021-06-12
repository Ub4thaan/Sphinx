using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sphinx.ValidationRules
{
    public class RegexValidationRule : ValidationRule
    {
        public string Rule { get; set; }
        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!Regex.IsMatch((string)value, Rule))
            {
                return new ValidationResult(false, ErrorMessage);
            }
            return ValidationResult.ValidResult;
        }
    }
}

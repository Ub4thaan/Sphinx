using Sphinx.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.ViewModels
{
    public class TextBoxViewModels<T> : BaseViewModel
    {
        public T Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                RaisePropertyChanged(nameof(Value));
            }
        }

        private T _Value;
    }
}

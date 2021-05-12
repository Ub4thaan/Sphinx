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
        public bool IsEnabled
        {
            get
            {
                return _IsEnabled;
            }
            set
            {
                if (_IsEnabled != value)
                {
                    _IsEnabled = value;
                    RaisePropertyChanged(nameof(IsEnabled));
                }
            }
        }
        public bool IsVisible
        {
            get
            {
                return _IsVisible;
            }
            set
            {
                if (_IsVisible != value)
                {
                    _IsVisible = value;
                    RaisePropertyChanged(nameof(IsVisible));
                }
            }
        }

        private T _Value;
        private bool _IsEnabled;
        private bool _IsVisible;
    }
}

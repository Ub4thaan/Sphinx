using Sphinx.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.ViewModels
{
    public class PopupViewModels : BaseViewModel
    {
        public bool IsOpen 
        {
            get
            {
                return _IsOpen;
            }
            set
            {
                if (_IsOpen != value)
                {
                    _IsOpen = value;
                    RaisePropertyChanged(nameof(IsOpen));
                }
            }
        }
        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                if (_Text != value)
                {
                    _Text = value;
                    RaisePropertyChanged(nameof(Text));
                }
            }
        }

        private bool _IsOpen;
        private string _Text;
    }
}

using Sphinx.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.ViewModels
{
    public class TextBoxViewModels : BaseViewModel
    {
        public virtual string Text 
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

        private string _Text;
    }

    
}

using Sphinx.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.ViewModels
{
    public class ComboBoxViewModels : BaseViewModel
    {
        public int SelectedIndex
        {
            get
            {
                return _SelectedIndex;
            }
            set
            {
                if (_SelectedIndex != value)
                {
                    _SelectedIndex = value;
                    RaisePropertyChanged(nameof(SelectedIndex));
                }
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

        private int _SelectedIndex;
        private bool _IsEnabled;
        private bool _IsVisible;
    }
}

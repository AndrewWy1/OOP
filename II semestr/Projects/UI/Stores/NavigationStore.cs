using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UI.ViewModels;

namespace UI.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentView;

        public ViewModelBase CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                CurrentViewChanged?.Invoke();
            }
        }

        public bool IsOpen => CurrentView != null;

        public event Action CurrentViewChanged;

        public void close()
        {
            CurrentView = null;
        }
    }
}

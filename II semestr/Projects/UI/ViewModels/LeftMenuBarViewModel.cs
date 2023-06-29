using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class LeftMenuBarViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ItemsForLeftBarViewModel> _itemsForLeftBarViewModels;

        public IEnumerable<ItemsForLeftBarViewModel> itemsForLeftBarViewModels  => _itemsForLeftBarViewModels;

        public LeftMenuBarViewModel() 
        {
            _itemsForLeftBarViewModels = new ObservableCollection<ItemsForLeftBarViewModel>();

            _itemsForLeftBarViewModels.Add(new ItemsForLeftBarViewModel("Users"));
            _itemsForLeftBarViewModels.Add(new ItemsForLeftBarViewModel("Booking"));
            _itemsForLeftBarViewModels.Add(new ItemsForLeftBarViewModel("Reviews"));
            _itemsForLeftBarViewModels.Add(new ItemsForLeftBarViewModel("Properties"));
        }

    }
}

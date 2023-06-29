using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Bll.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UI.ViewModels
{
    public class ItemsForLeftBarViewModel : ViewModelBase
    {
        public string Name { get; }

        public ItemsForLeftBarViewModel(string name)
        {
            Name = name;
        }
    }
}

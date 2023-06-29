using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Dal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI.Commands;

namespace UI.ViewModels
{
    public class ShowUserViewModel : ViewModelBase
    {
        public LeftMenuBarViewModel leftMenuBarViewModel { get;}
        public ShowTableViewModel showTableViewModel { get; }

        public ICommand AddNewUserCommand { get; }

        public ShowUserViewModel()
        {
            leftMenuBarViewModel = new LeftMenuBarViewModel();
            showTableViewModel = new ShowTableViewModel();
        }
    }
}

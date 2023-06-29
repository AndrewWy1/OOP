using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Dal.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UI.ViewModels
{
    public class ShowTableViewModel : ViewModelBase
    {
        public ICommand EditCommand { get; }
        public ICommand RemoveCommand { get; }

        public ObservableCollection<User> Users;

        public ShowTableViewModel()
        {
            // Ініціалізація колекції з даними
            Users = new ObservableCollection<User>
        {
            new User {FirstName = "John", LastName = "Doe", Email = "johndoe@example.com", Username = "johndoe", Password = "password1" },
            new User{FirstName = "Jane", LastName = "Smith", Email = "janesmith@example.com", Username = "janesmith", Password = "password2" },
            new User {FirstName = "Mike", LastName = "Johnson", Email = "mikejohnson@example.com", Username = "mikejohnson", Password = "password3" }
        };
        }

    }
}

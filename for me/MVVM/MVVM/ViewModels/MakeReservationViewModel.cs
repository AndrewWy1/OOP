using MVVM.Commands;
using MVVM.Models;
using System;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string Username { 
            get { return _username;} 
            set { 
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }
        private int _roomNumber;
        public int RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private DateTime _startDate = new DateTime(2021, 1, 1);
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDatenew = new DateTime(2021, 1, 8);
        public DateTime EndDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        public ICommand SubmitCommand { get;}
        public ICommand CancelCommand { get; }


        public MakeReservationViewModel(Hotel hotel)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel);
        }
    }
}

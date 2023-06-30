using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation;

        public IEnumerable<ReservationViewModel> Reservations => _reservation;

        public ICommand MakeReservationCommand { get;}

        public ReservationListingViewModel()
        {
            _reservation = new ObservableCollection<ReservationViewModel>();

            _reservation.Add(
                new ReservationViewModel(new Reservation(new RoomId(1, 2), "Andrew", DateTime.Now, DateTime.Now)));

            _reservation.Add(
               new ReservationViewModel(new Reservation(new RoomId(3, 2), "Andrew", DateTime.Now, DateTime.Now)));

            _reservation.Add(
               new ReservationViewModel(new Reservation(new RoomId(2, 4), "Andrew", DateTime.Now, DateTime.Now)));
        }
    }
}

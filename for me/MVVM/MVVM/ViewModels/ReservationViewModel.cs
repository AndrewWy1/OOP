using MVVM.Models;
using System;

namespace MVVM.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private Reservation _reservation;

        public string RoomId => _reservation.RoomId.ToString();
        public string UserName => _reservation.UserName;
        public DateTime StartDate => _reservation.StartTime.Date;
        public DateTime EndDate => _reservation.EndTime.Date;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
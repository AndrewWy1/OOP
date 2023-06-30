using MVVM.Exceptions;
using MVVM.Models;
using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomId(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate);
            try
            {
                _hotel.MakeReservation(reservation);

                MessageBox.Show("Seccesfully", "Success",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("This room is already taken", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

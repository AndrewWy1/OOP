using MVVM.Models;

namespace MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel {get; }

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new MakeReservationViewModel(hotel);
        }
    }
}

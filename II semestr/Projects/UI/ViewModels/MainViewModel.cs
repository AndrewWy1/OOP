using UI.Stores;

namespace UI.ViewModels
{
    public class MainViewModel
    {
        private readonly NavigationStore _navigationStore;

        public ViewModelBase CurrentModelViewModel => _navigationStore.CurrentView;

        public bool IsOpen => _navigationStore.IsOpen;
    }
}

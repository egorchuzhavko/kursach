using project.Core;

namespace project.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand StafViewCommand { get; set; }
        public RelayCommand ItemViewCommand { get; set; }
        public RelayCommand BasketViewCommand { get; set; }
        public RelayCommand ItemsInRentViewCommand { get; set; }

        public StafViewModel StafVM { get; set; }
        public ItemViewModel ItemVM { get; set; }
        public BasketViewModel BasketVM { get; set; }
        public ItemsInRentViewModel ItemInRentVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            StafVM = new StafViewModel();
            ItemVM = new ItemViewModel();
            BasketVM = new BasketViewModel();
            ItemInRentVM = new ItemsInRentViewModel();
            CurrentView = StafVM;

            StafViewCommand = new RelayCommand(o =>
            {
                CurrentView = StafVM;
            });
            ItemViewCommand = new RelayCommand(o =>
            {
                CurrentView = ItemVM;
            });
            BasketViewCommand = new RelayCommand(o =>
            {
                CurrentView = BasketVM;
            });
            ItemsInRentViewCommand = new RelayCommand(o =>
            {
                CurrentView = ItemInRentVM;
            });
        }
    }
}

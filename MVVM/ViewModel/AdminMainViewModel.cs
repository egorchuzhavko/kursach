using project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.MVVM.ViewModel
{
    internal class AdminMainViewModel : ObservableObject
    {
        public RelayCommand StatisticsViewCommand { get; set; }
        public RelayCommand ItemViewCommand { get; set; }
        public RelayCommand UserViewCommand { get; set; }
        public RelayCommand ContractViewCommand { get; set; }

        public StatisticsViewModel StatisticsVM { get; set; }
        public AdminItemViewModel ItemVM { get; set; }
        public UserViewModel UserVM { get; set; }
        public ContractViewModel ContractVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public AdminMainViewModel()
        {
            StatisticsVM = new StatisticsViewModel();
            ItemVM = new AdminItemViewModel();
            UserVM = new UserViewModel();
            ContractVM = new ContractViewModel();
            CurrentView = StatisticsVM;

            StatisticsViewCommand = new RelayCommand(o =>
            {
                CurrentView = StatisticsVM;
            });
            ItemViewCommand = new RelayCommand(o =>
            {
                CurrentView = ItemVM;
            });
            UserViewCommand = new RelayCommand(o =>
            {
                CurrentView = UserVM;
            });
            ContractViewCommand = new RelayCommand(o =>
            {
                CurrentView = ContractVM;
            });
        }
    }
}

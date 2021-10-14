using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace XamarinUIMockUp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            dummyList = new ObservableCollection<string>() 
            { 
                "Helllo",
                "d",
                "f",
                "d",
                "ss",
                "as"
            };
            DetailCommand = new DelegateCommand(OnDetailRequested);

        }

        private void OnDetailRequested()
        {
            NavigationService.NavigateAsync("DetailPage");
            SelectedItem = null;
        }

        public ICommand DetailCommand { get; }
        public ObservableCollection<string> dummyList { get; set; }
        private object _selectedItem;
        public object SelectedItem 
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
                if (_selectedItem != null)
                {
                    DetailCommand.Execute(_selectedItem);
                    SelectedItem = null;
                }
            }
        }
    }
}

using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using XamarinUIMockUp.Models;

namespace XamarinUIMockUp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand DetailCommand { get; }
        private MenuItem _selectedItem;
        public MenuItem SelectedItem
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

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            MenuList = new ObservableCollection<MenuItem>();
            MenuList.Add(new MenuItem("Iron Man", "\U0001F552 2 hours", "ironmanPoster.jpg"));
            DetailCommand = new DelegateCommand(OnDetailRequested);

        }

        private void OnDetailRequested()
        {
            var parameter = new NavigationParameters();
            parameter.Add("SelectedItemMenu", SelectedItem);
            NavigationService.NavigateAsync("DetailPage", parameter);
            SelectedItem = null;
        }

        
        public ObservableCollection<MenuItem> MenuList { get; set; }

    }
}

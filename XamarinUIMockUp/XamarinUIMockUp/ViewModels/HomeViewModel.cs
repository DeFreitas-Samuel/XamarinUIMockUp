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
        public CustomButtonData CustomButtonData1 { get; }
        public CustomButtonData CustomButtonData2 { get; }
        public CustomButtonData CustomButtonData3 { get; }
        public CustomButtonData CustomButtonData4 { get; }
        public string Categories {get;} = "Categories";
        public string DailyRecommendation { get; } = "Daily Recommendation";
        public string NewMovies { get; } = "New Movies";
        public string ViewAll { get; } = "View All";
        public string Terminator2 { get; } = "Terminator2";
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
            CustomButtonData1 = new CustomButtonData("Action", "actionIcon");
            CustomButtonData2 = new CustomButtonData("Drama", "dramaIcon");
            CustomButtonData3 = new CustomButtonData("Romance", "romanceIcon");
            CustomButtonData4 = new CustomButtonData("Horror", "horrorIcon");
            MenuList = new ObservableCollection<MenuItem>
            {
                new MenuItem("Iron Man", "\U0001F552 122 minutes", "ironmanPoster.jpg"),
                new MenuItem("Pirates of the Caribbean", "\U0001F552 90 minutes", "piratesPoster.jpg"),
                new MenuItem("Batman", "\U0001F552 136 minutes", "batmanPoster.jpg"),
                new MenuItem("Lord of the Ring", "\U0001F552 126 minutes", "lordOfTheRingPoster.jpg"),
                new MenuItem("Spider-man Into The Spiderverse", "\U0001F552 96 minutes", "spidermanPoster.jpg")
            };

            DetailCommand = new DelegateCommand(OnDetailRequested);

        }

        private void OnDetailRequested()
        {
            var parameter = new NavigationParameters();
            parameter.Add("SelectedItemMenu", SelectedItem);
            NavigationService.NavigateAsync(NavigationConstants.Paths.Detail, parameter);
            SelectedItem = null;
        }

        
        public ObservableCollection<MenuItem> MenuList { get; set; }

    }
}

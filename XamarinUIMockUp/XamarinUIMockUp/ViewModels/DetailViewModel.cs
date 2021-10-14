using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinUIMockUp.Models;

namespace XamarinUIMockUp.ViewModels
{
    public class DetailViewModel : BaseViewModel, INavigatedAware
    {
        private MenuItem SelectedItem { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string TimeRequired { get; set; }
        public string Description { get; set; }
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            SelectedItem = (MenuItem)parameters["SelectedItemMenu"];
            Title = SelectedItem.Title;
            Image = SelectedItem.Image;
            TimeRequired = SelectedItem.TimeRequired;
            Description = MenuItem.Description;
        }
    }
}

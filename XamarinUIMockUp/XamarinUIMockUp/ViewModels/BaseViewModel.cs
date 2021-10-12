using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinUIMockUp.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected INavigationService NavigationService { get; }
    }
}

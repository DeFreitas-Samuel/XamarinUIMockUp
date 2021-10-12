using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
           
        }

        public ObservableCollection<string> dummyList { get; set; }
    }
}

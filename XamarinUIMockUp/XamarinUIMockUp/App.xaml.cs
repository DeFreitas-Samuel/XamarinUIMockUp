using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUIMockUp.ViewModels;
using XamarinUIMockUp.Views.Pages;

namespace XamarinUIMockUp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();

        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(NavigationConstants.Paths.MainTabbed);
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainTabbedPage>("MainTab");
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<DetailPage, DetailViewModel>();
        }
    }
}

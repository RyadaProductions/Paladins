using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paladins.Views;
using Xamarin.Forms;

namespace Paladins
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }
        private static RootPage RootPage;
        public static bool MenuIsPresented
        {
            get => RootPage.IsPresented;
            set => RootPage.IsPresented = value;
        }

        public App()
        {
            InitializeComponent();

            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new HomePage());
            RootPage = new RootPage
            {
                Master = menuPage,
                Detail = NavigationPage
            };
            MainPage = RootPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

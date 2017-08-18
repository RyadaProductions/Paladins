using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Paladins.Views;
using Paladins.Views.Pages;
using Xamarin.Forms;

namespace Paladins.ViewModels
{
    public class MenuPageViewModel
    {
        //public ICommand GoHomeCommand { get; set; }
        //public ICommand GoSecondCommand { get; set; }
        public ObservableCollection<MenuItemViewModel> MenuList = new ObservableCollection<MenuItemViewModel>();

        public MenuPageViewModel()
        {
            //GoHomeCommand = new Command(GoHome);
            //GoSecondCommand = new Command(GoPage);
            MenuList.Add(new MenuItemViewModel{ Name = "Home", PageType = typeof(HomePage) });
            MenuList.Add(new MenuItemViewModel { Name = "Champions", PageType = typeof(Champions) });
        }

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoPage(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new Champions());
            App.MenuIsPresented = false;
        }
    }
}

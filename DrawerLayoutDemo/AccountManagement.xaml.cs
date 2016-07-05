using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DrawerLayoutDemo
{
    public partial class AccountManagement : PhoneApplicationPage
    {
        public AccountManagement()
        {
            InitializeComponent();
                       DrawerLayout.InitializeDrawerLayout();
        }

        private void DrawerIcon_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();
            else
                DrawerLayout.OpenDrawer();
        }
        private void Item_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
            {
                string menuItemName = grid.Name;

                switch (menuItemName)
                {
                    case "Item1":
                        NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                        DrawerLayout.CloseDrawer();
                        break;

                    case "Item3":
                        //NavigationService.Navigate(new Uri("/Statistics.xaml", UriKind.Relative));
                        break;

                    case "Item4":
                        //NavigationService.Navigate(new Uri("/Statistics.xaml", UriKind.Relative));
                        break;
                }
            }
        }
    }
}
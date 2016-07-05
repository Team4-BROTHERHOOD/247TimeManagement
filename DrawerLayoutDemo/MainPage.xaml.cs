using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace DrawerLayoutWP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.BackKeyPress += MainPage_BackKeyPress;
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
                    case "Item2":
                        //NavigationService.Navigate(new Uri("/AccountManagement.xaml", UriKind.Relative));
                        //DrawerLayout.CloseDrawer();
                        break;

                    case "Item3":
                        NavigationService.Navigate(new Uri("/AccountManagement.xaml", UriKind.Relative));
                        DrawerLayout.CloseDrawer();
                        break;

                    case "Item4":
                        //NavigationService.Navigate(new Uri("/Statistics.xaml", UriKind.Relative));
                        break;
                }
            }
        }
        private void MainPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);

            if (DrawerLayout.IsDrawerOpen)
            {
                DrawerLayout.CloseDrawer();
                e.Cancel = true;
            }
        }
    }
}
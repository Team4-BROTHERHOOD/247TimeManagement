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
    public partial class AddProject : PhoneApplicationPage
    {
        public AddProject()
        {
            InitializeComponent();
           // txtdata.Text = ((DateTime)dtpStart.Value).ToShortDataSting();
            for (int i = 1; i <= 3; i++)
            {
                lpSemester.Items.Add(i);
            }
            for (int i = 2015; i <= 2100; i++)
            {
                lpSYear.Items.Add(i+"-"+(i+1));
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("You has added successfully project", "Congratulation", MessageBoxButton.OK);

            if (result == MessageBoxResult.OK)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }
    }
}
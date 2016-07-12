using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace DrawerLayoutDemo
{
    public partial class Introduction : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tick = 0;
        public Introduction()
        {
            this.InitializeComponent();
            prBr.IsIndeterminate = true;
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        //make method to count time
        void timer_Tick(object sender, object e)
        {
            tick++;
            if (tick == 1)
            {
                loading.Opacity = 0.2;
            }
            if (tick == 2)
            {
                loading.Opacity = 0.4;
            }
            if (tick == 3)
            {
                loading.Opacity = 0.6;
            }
            if (tick == 4)
            {
                loading.Opacity = 0.8;
            }
            if (tick == 5)
            {
                loading.Opacity = 1;
            }
            if (tick == 7)
            {
                NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
            }
        }
    }
}

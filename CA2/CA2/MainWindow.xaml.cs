﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Activity activity1 = new Activity("Surfing", new DateTime(2019, 6, 1), 20m, ActivityType.Water, "Fun in the waves");
            Activity activity2 = new Activity("Basketball", new DateTime(2019, 4, 20), 10m, ActivityType.Land, "KOBE!");
            Activity activity3 = new Activity("Hot Air Balloon", new DateTime(2019, 7, 15), 60m, ActivityType.Air, "See all the views up in the air");
            Activity activity4 = new Activity("Surfing", new DateTime(2019, 6, 1), 20m, ActivityType.Water, "Fun in the waves");
            Activity activity1 = new Activity("Surfing", new DateTime(2019, 6, 1), 20m, ActivityType.Water, "Fun in the waves");
        }
    }
}

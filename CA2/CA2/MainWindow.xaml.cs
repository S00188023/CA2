using System;
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
        List<Activity> allActivities = new List<Activity>();
        List<Activity> selectedActivities = new List<Activity>();
        List<Activity> filteredActivities = new List<Activity>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Activity activity1 = new Activity("Surfing", new DateTime(2019, 6, 1), 20m, ActivityType.Water, "Fun in the waves");
            Activity activity2 = new Activity("Basketball", new DateTime(2019, 4, 20), 10m, ActivityType.Land, "5 v 5");
            Activity activity3 = new Activity("Hot Air Balloon", new DateTime(2019, 7, 15), 60m, ActivityType.Air, "See all the views up in the air");
            Activity activity4 = new Activity("Jet Ski", new DateTime(2019, 8, 17), 40m, ActivityType.Water, "Don't fall off");
            Activity activity5 = new Activity("Football", new DateTime(2019, 6, 1), 10m, ActivityType.Land, "11 v 11");

            allActivities.Add(activity1);
            allActivities.Add(activity2);
            allActivities.Add(activity3);
            allActivities.Add(activity4);
            allActivities.Add(activity5);

            lbxAllActivities.ItemsSource = allActivities;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Activity selectedActivity = lbxAllActivities.SelectedItem as Activity;

            if (selectedActivity != null)
            {
                allActivities.Remove(selectedActivity);
                selectedActivities.Add(selectedActivity);

                lbxAllActivities.ItemsSource = null;
                lbxAllActivities.ItemsSource = allActivities;

                lbxSelectedActivities.ItemsSource = null;
                lbxSelectedActivities.ItemsSource = selectedActivities;
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Activity selectedActivity = lbxSelectedActivities.SelectedItem as Activity;

            if (selectedActivity != null)
            {
                allActivities.Add(selectedActivity);
                selectedActivities.Remove(selectedActivity);
                RefreshScreen();
            }
        }

        private void RefreshScreen()
        {
            lbxAllActivities.ItemsSource = null;
            lbxAllActivities.ItemsSource = allActivities;

            lbxSelectedActivities.ItemsSource = null;
            lbxSelectedActivities.ItemsSource = selectedActivities;
        }

        private void RbAll_Click(object sender, RoutedEventArgs e)
        {
            filteredActivities.Clear();
            if (rbAll.IsChecked == true)
            {
                RefreshScreen();
            }
            if (rbLand.IsChecked == true)
            {
                foreach(Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Land)
                    {
                        filteredActivities.Add(activity);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = filteredActivities;
                    }
                }
            }
            if (rbWater.IsChecked == true)
            {
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Water)
                    {
                        filteredActivities.Add(activity);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = filteredActivities;
                    }
                }
            }
            if (rbAir.IsChecked == true)
            {
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Air)
                    {
                        filteredActivities.Add(activity);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = filteredActivities;
                    }
                }
            }
        }

    }
}

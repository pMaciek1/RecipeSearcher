using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeSearcher
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        private string meal;
        public DetailsWindow(string meal)
        {
            InitializeComponent();
            this.meal = meal;
            gDataBindingDetails.DataContext = FoodDB.GetMealDetails(meal);
            
        }
        private void LinkClick(object sender, RoutedEventArgs e)
        {
            string link = ((TextBlock)sender).Text as String;
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName=link,
                    UseShellExecute = true
                });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void LoadedEvent(object sender, RoutedEventArgs e)
        {
            if(((TextBlock)sender).Text == "" || ((TextBlock)sender).Text == null || ((TextBlock)sender).Text == " ")
            {
                ((TextBlock)sender).Visibility = Visibility.Collapsed;
            }
        }
        private void YoutubeEvent(object sender, RoutedEventArgs e)
        {
            if (((TextBlock)sender).Text == "" || ((TextBlock)sender).Text == null || ((TextBlock)sender).Text == " ")
            {
                ((TextBlock)sender).Visibility= Visibility.Collapsed;
                YoutubeText.Visibility = Visibility.Collapsed;
            }
        }
        private void TagsEvent(object sender, RoutedEventArgs e)
        {
            if (((TextBlock)sender).Text == "" || ((TextBlock)sender).Text == null || ((TextBlock)sender).Text == " ")
            {
                ((TextBlock)sender).Visibility = Visibility.Collapsed;
                TagsText.Visibility = Visibility.Collapsed;
            }
        }
    }
}

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
using System.Windows.Shapes;

namespace RecipeSearcher
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }
        void SearchClick(object sender, RoutedEventArgs e)
        {
            string searchString = InputBox.Text;
            lvDataBindingMeals.Items.Clear();
            lvDataBindingMeals.ItemsSource = FoodDB.GetSearchMeals(searchString);
        }
        void SearchKeyboard(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                string searchString = InputBox.Text;
                lvDataBindingMeals.Items.Clear();
                lvDataBindingMeals.ItemsSource = FoodDB.GetSearchMeals(searchString);
            }
        }
        void MealClick(object sender, RoutedEventArgs e)
        {
            string meal = ((Border)sender).Tag as String;
            DetailsWindow detailsWindow = new DetailsWindow(meal);
            detailsWindow.Show();
        }
    }
}

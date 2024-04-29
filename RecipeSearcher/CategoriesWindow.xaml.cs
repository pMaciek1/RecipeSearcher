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
    /// Interaction logic for CategoriesWindow.xaml
    /// </summary>
    public partial class CategoriesWindow : Window
    {
        public CategoriesWindow()
        {
            InitializeComponent();
            lvDataBindingCategories.ItemsSource = FoodDB.GetCategories();
        }
        private void CategoryClick(object sender, RoutedEventArgs e)
        {
            string category = ((Border)sender).Tag as String;
            lvDataBindingMeals.ItemsSource = FoodDB.GetMealsCategory(category);
            lvDataBindingCategories.Visibility = Visibility.Hidden;
            lvDataBindingMeals.Visibility = Visibility.Visible;
            backButton.Visibility = Visibility.Visible;
        }
        void MealClick(object sender, RoutedEventArgs e)
        {
            string meal = ((Border)sender).Tag as String;
            DetailsWindow detailsWindow = new DetailsWindow(meal);
            detailsWindow.Show();
        }
        private void BackClick(object sender, RoutedEventArgs e)
        {
            lvDataBindingCategories.Visibility = Visibility.Visible;
            lvDataBindingMeals.Visibility = Visibility.Hidden;
            backButton.Visibility = Visibility.Hidden;
        }
    }
}

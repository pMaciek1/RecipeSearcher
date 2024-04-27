using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using RestSharp;

namespace RecipeSearcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            lvDataBindingCategories.ItemsSource = FoodDB.GetCategories();
        }
        private void CategoryClick(object sender, RoutedEventArgs e)
        {
            string category = ((Border)sender).Tag as String;
            lvDataBindingMeals.ItemsSource = FoodDB.GetMeals(category);
            lvDataBindingCategories.Visibility = Visibility.Hidden;
            lvDataBindingMeals.Visibility = Visibility.Visible;
        }
        void MealClick(object sender, RoutedEventArgs e)
        {
            string meal = ((Border)sender).Tag as String;
            DetailsWindow detailsWindow = new DetailsWindow(meal);
            detailsWindow.Show();
        }
    }
}
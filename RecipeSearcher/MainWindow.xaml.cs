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
        }
        void RandomClick(object sender, RoutedEventArgs e)
        {
            DetailsWindow detailsWindow = new DetailsWindow(FoodDB.RandomMeal());
            detailsWindow.Show();
        }
        void GetCountriesClick(object sender, RoutedEventArgs e)
        {
            CountriesWindow countriesWindow = new CountriesWindow();
            countriesWindow.Show();
        }
        void GetCategoriesClick(object sender, RoutedEventArgs e)
        {
            CategoriesWindow categoriesWindow = new CategoriesWindow();
            categoriesWindow.Show();
        }
        void GetSearchClick(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();
        }
    }
}
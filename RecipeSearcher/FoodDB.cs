using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace RecipeSearcher
{
    public class FoodDB
    {

        public static List<Category> GetCategories()
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest("categories.php");
            var response = client.ExecuteAsync(requestList);
            List<Category> categories = new();
            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string gotResponse = response.Result.Content;
                var deserialize = JsonConvert.DeserializeObject<Categories>(gotResponse);
                categories = deserialize.CategoriesList;
                return categories;
            }
            return categories;
        }
        public List<Meal> searchGeneral(string searchString)
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest("search.php?s=" + searchString);
            var response = client.ExecuteAsync(requestList);
            List<Meal> meals = new();
            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string gotResponse = response.Result.Content;
                var deserialize = JsonConvert.DeserializeObject<Meals>(gotResponse);
                meals = deserialize.MealsList;
                return meals;
            }
            return meals;
        }
    }
}

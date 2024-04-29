using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using RestSharp;

namespace RecipeSearcher
{
    public class FoodDB
    {

        public static List<Category> GetCategories()
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest("list.php?c=list");
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
        public static List<Country> GetCountries()
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest("list.php?a=list");
            var response = client.ExecuteAsync(requestList);
            List<Country> countries = new();
            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string gotResponse = response.Result.Content;
                var deserialize = JsonConvert.DeserializeObject<Countries>(gotResponse);
                countries = deserialize.CountryList;
                return countries;
            }
            return countries;
        }
        public static List<Meal> GetMealsCategory(string category)
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest($"filter.php?c={HttpUtility.UrlEncode(category)}");
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
        public static List<Meal> GetMealsCountry(string country)
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest($"filter.php?a={HttpUtility.UrlEncode(country)}");
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
        public static List<Meal> GetSearchMeals(string searchString)
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest("search.php?s=" + HttpUtility.UrlEncode(searchString));
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
        public static List<Detail> GetMealDetails(string mealId)
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest($"lookup.php?i={HttpUtility.UrlEncode(mealId)}");
            var response= client.ExecuteAsync(requestList);
            List<Detail> details = new();
            if(response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string gotResponse = response.Result.Content;
                var deserialize = JsonConvert.DeserializeObject<Details> (gotResponse);
                details = deserialize.DetailsList;
                return details;
            }
            return details;
        }
        public static string RandomMeal()
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/");
            var requestList = new RestRequest("random.php");
            var response = client.ExecuteAsync(requestList);
            List<Detail> details=new();
            string id="";
            
            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string gotResponse = response.Result.Content;
                var deserialize = JsonConvert.DeserializeObject<Details>(gotResponse);
                details = deserialize.DetailsList;
                id = details[0].idMeal;
                return id;
            }
            return id;
        }
        
        
        
    }
}

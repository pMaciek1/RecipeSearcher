using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RecipeSearcher
{
    public class Meal
    {
        public string idMeal {  get; set; }
        public string strMeal { get; set;}
        public string strMealThumb { get; set;}
        public override string ToString()
        {
            return this.idMeal + ". " + this.strMeal;
        }
    }
    public class Meals
    {
        [JsonProperty("meals")]
        public List<Meal> MealsList { get; set; }
    }
}

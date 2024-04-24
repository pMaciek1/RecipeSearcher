using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSearcher
{
    public class Meal
    {
        public string idMeal {  get; set; }
        public string nameMeal { get; set;}
    }
    public class Meals
    {
        public List<Meal> MealsList { get; set; }
    }
}

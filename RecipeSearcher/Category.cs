using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RecipeSearcher
{
    public class Category
    {
        public int idCategory { get; set; }
        public string strCategory {  get; set; }
        public string strCategoryDescription { get; set; }
        public override string ToString()
        {
            return this.idCategory + ". " + this.strCategory + ".\n Description: " + this.strCategoryDescription;
        }
    }
    public class Categories
    {
        [JsonProperty("categories")]
        public List<Category> CategoriesList { get; set; }
    }
}

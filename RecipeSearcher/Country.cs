using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RecipeSearcher
{
    public class Country
    {
        public string strArea { get; set; }
    }
    public class Countries
    {
        [JsonProperty("meals")]
        public List<Country> CountryList {  get; set; }

    }
}

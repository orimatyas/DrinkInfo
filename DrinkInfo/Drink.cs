using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DrinkInfo.Models
{
    public class Drink
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public bool favDrink { get; set; } = false;
    }
    public class Drinks
    {
        [JsonProperty("drinks")]
        public List<Drink> DrinksList { get; set; }
    }
}

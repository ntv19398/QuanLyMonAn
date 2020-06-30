using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp.Source
{
    public class Recipe
    {
        public int IdFood { get; set; }

        public string urlVideo { get; set; }
        public List<Step> lstStep { get; set; }
    }
}

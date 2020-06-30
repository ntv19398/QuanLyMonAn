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
        public Recipe(int id, string url, List<Step>lst)
        {
            this.IdFood = id;
            this.urlVideo = url;
            this.lstStep = lst;
        }
        public Recipe()
        {

        }
    }
}

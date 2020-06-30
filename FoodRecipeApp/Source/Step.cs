using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp.Source
{
    public class Step
    {
        public string urlImage { get; set; }
        public string Description { get; set; }

        public Step(string image, string mota)
        {
            this.urlImage = image;
            this.Description = mota;
        }
        public Step()
        {

        }
    }
}

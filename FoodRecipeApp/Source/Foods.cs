using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp.Source
{
    public class Foods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string urlImage { get; set; }
        public bool isLike { get; set; }

        public Foods()
        {
        }
        public Foods(int id, string name, string urlimage, bool islike)
        {
            this.Id = id;
            this.Name = name;
            this.urlImage = urlimage;
            this.isLike = islike;
        }
    }
}

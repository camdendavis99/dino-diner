using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Chicken",
                    "Wing Sauce"
                };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
    }
}

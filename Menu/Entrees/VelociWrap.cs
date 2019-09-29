/*  VelociWrap.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Whether or not the wrap will have Ceasar dressing
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Whether or not the wrap will have lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether or not the wrap will have cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Gets the list of ingredients based on which were chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Flour Tortilla",
                    "Chicken Breast"
                };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new VelociWrap with default Price and Calories
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Removes Ceasar dressing
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }

        /// <summary>
        /// Removes lettuce
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Removes cheese
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
    }
}

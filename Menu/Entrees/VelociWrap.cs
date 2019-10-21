/*  VelociWrap.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        public override string Description => ToString();

        /// <summary>
        /// Returns a list of special properties of the entree
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}

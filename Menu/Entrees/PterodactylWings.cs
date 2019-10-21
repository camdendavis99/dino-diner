/*  PterodactylWings.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Gets the list of ingredients based on which have been chosen
        /// </summary>
        public override List<string> Ingredients
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

        /// <summary>
        /// Creates a new PterodactylWings with default Price and Calories
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
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
                return special.ToArray();
            }
        }
    }
}

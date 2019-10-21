/*  DinoNuggets.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Number of nuggets in the entree
        /// </summary>
        private uint nuggetCount = 6;

        /// <summary>
        /// Gets the list of ingredients based on the number of nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new DinoNuggets with default Price and Calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * this.nuggetCount;
        }

        /// <summary>
        /// Adds a nugget to the entree
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount++;
            this.Price += 0.25;
            this.Calories += 59;
        }

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if (nuggetCount > 6) special.Add($"{nuggetCount} Nuggets");
                return special.ToArray();
            }
        }
    }
}

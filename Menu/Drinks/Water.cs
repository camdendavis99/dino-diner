/*  Water.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        /// <summary>
        /// Whether or not the water has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets the list of ingredients based on which have been chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Water"};
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new Water with default Size, Price, and Calories
        /// </summary>
        public Water() : base()
        {
            Price = 0.10;
            Calories = 0;
        }

        /// <summary>
        /// Adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Returns a string representation for water, including size.
        /// </summary>
        /// <returns>String representation of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Water";
        }

        /// <summary>
        /// Returns a description of the drink
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Returns a list of special properties of the drink
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}

/*  SteakosaurusBurger.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Whether or not the burger will have a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether or not the burger will have pickles
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Whether or not the burger will have ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Whether or not the burger will have mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Gets the list of ingredients based on which have been chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new SteakosaurusBurger with default Price and Calories
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }

        /// <summary>
        /// Removes bun
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        
        /// <summary>
        /// Removes pickles
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }

        /// <summary>
        /// Removes ketchup
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }

        /// <summary>
        /// Removes mustard
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
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
                if (!bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
    }
}

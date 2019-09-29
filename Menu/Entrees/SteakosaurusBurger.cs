/*  SteakosaurusBurger.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
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
    }
}

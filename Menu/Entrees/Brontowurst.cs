/*  Brontowurst.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Whether or not the Brontowurst will have a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether or not the Brontowurst will have peppers
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Whether or not the Brontowurst will have onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Gets the list of ingredients based on which have been chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new Brontowurst with default Price and Calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Returns a list of special properties of the entree
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onion");
                return special.ToArray();
            }
        }
    }
}

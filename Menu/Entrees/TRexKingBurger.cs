﻿/*  TRexKingBurger.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Whether or not the burger will have a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether or not the burger will have lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether or not the burger will have tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Whether or not the burger will have onion
        /// </summary>
        private bool onion = true;

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
        /// Whether or not the burger will have mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Number of patties on the burger
        /// </summary>
        private uint pattieCount { get; set; }

        /// <summary>
        /// Gets the list of ingredients based on which have been chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < pattieCount; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");

                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new TRexKingBurger with default patty count, Price, and Calories
        /// </summary>
        public TRexKingBurger()
        {
            pattieCount = 3;
            Price = 8.45;
            Calories = 728;
        }

        /// <summary>
        /// Removes bun
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }

        /// <summary>
        /// Removes lettuce
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Removes tomato
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }

        /// <summary>
        /// Removes onion
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
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
        /// Removes mayo
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                if (pattieCount != 3) special.Add($"{pattieCount} Patties");
                return special.ToArray();
            }
        }
    }
}

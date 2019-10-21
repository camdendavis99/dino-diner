/*  Tyrannotea.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Stores whether or not the tea has sweetener
        /// </summary>
        private bool sweet = false;

        /// <summary>
        /// Whether or not the tea has sweetener. Doubles Calories if sweet.
        /// </summary>
        public bool Sweet
        {
            get => sweet;
            set
            {
                if (sweet != value)
                {
                    if (value)
                        Calories *= 2;
                    else
                        Calories /= 2;
                    sweet = value;
                }
            }
        }

        /// <summary>
        /// Whether or not the tea has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets or sets the size, and sets the Price or Calories accordingly
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    default:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                if (sweet) Calories *= 2;
            }
        }

        /// <summary>
        /// Gets the list of ingredients based on which have been chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Water",
                    "Tea",
                };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new Tyrannotea with default Size, Price, and Calories
        /// </summary>
        public Tyrannotea() : base() { }

        /// <summary>
        /// Adds lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Returns a string representation for Tyrannotea, including size
        /// and whether or not it is sweet.
        /// </summary>
        /// <returns>String representation of the drink</returns>
        public override string ToString()
        {
            if (Sweet)
                return $"{Size} Sweet Tyrannotea";
            else
                return $"{Size} Tyrannotea";
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

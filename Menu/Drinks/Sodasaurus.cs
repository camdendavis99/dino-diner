/*  Sodasaurus.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Gets or sets the flavor
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    default:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>()
                {
                    "Water",
                    "Natural Flavors",
                    "Cane Sugar"
                };
            }
        }

        /// <summary>
        /// Creates a new Sodasaurus with default Size, Price, and Calories
        /// </summary>
        public Sodasaurus() : base() { }

        /// <summary>
        /// Returns a string representation for Sodasaurus, including size
        /// and flavor.
        /// </summary>
        /// <returns>String representation of the drink</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}

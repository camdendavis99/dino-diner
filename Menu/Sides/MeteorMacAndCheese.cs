/*  MeteorMacAndCheese.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    default:
                        Price = 1.95;
                        Calories = 520;
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
                    "Macaroni Noodles",
                    "Cheese Product",
                    "Pork Sausage"
                };
            }
        }

        /// <summary>
        /// Creates a new MeteorMacAndCheese with 
        /// default Size, Price, and Calories
        /// </summary>
        public MeteorMacAndCheese()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public override string ToString()
        {
            return $"{Size} Meteor Mac and Cheese";
        }

        /// <summary>
        /// Returns a description of the side
        /// </summary>
        public string Description => ToString();
    }
}

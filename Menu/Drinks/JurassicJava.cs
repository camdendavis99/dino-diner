/*  JurassicJava.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Whether or not to leave room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether or not the coffee is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    default:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
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
                    "Coffee"
                };
            }
        }

        /// <summary>
        /// Creates a new JurassicJava with default Size, Price, and
        /// Calories, but with no ice.
        /// </summary>
        public JurassicJava() : base()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;
        }

        /// <summary>
        /// Leaves room for cream in the coffee
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds ice to the coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Returns a string representation for jurassic java, including size
        /// and whether or not it is decaf.
        /// </summary>
        /// <returns>String representation of the drink</returns>
        public override string ToString()
        {
            if (Decaf)
                return $"{Size} Decaf Jurassic Java";
            else
                return $"{Size} Jurassic Java";
        }

        /// <summary>
        /// Returns a list of special properties of the drink
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Add Cream");
                return special.ToArray();
            }
        }
    }
}

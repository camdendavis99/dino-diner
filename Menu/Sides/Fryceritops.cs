using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    default:
                        Price = 1.95;
                        Calories = 480;
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
                    "Potato",
                    "Salt",
                    "Vegetable Oil"
                };
            }
        }

        /// <summary>
        /// Creates a new Fryceritops with default 
        /// Size, Price, and Calories
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
        }
    }
}

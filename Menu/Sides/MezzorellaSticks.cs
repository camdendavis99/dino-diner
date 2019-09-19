﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    default:
                        Price = 1.95;
                        Calories = 720;
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
                    "Breading",
                    "Cheese Product",
                    "Vegetable Oil"
                };
            }
        }

        /// <summary>
        /// Creates a new MezzorellaSticks with default 
        /// Size, Price, and Calories
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }
    }
}

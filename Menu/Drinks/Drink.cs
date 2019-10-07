/*  Drink.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// Stores the size
        /// </summary>
        protected Size size;

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets whether or not the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Removes ice from the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Creates a new drink with default size, price, and calories
        /// </summary>
        public Drink()
        {
            Size = Size.Small;
        }
    }
}
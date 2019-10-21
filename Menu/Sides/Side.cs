/*  Side.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side : IMenuItem
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
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets the description of the side
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Returns a list of special properties of the side (none)
        /// </summary>
        public string[] Special => new string[0];
    }
}

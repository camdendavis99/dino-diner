/*  Entree.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem
    {
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
        /// Gets the description of the drink
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Gets the list of special properties
        /// </summary>
        public virtual string[] Special { get; }
    }
}

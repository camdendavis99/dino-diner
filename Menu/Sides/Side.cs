/*  Side.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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

        // <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public abstract override string ToString();

        /// <summary>
        /// Gets the description of the drink
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Returns a list of special properties of the side (none)
        /// </summary>
        public string[] Special => new string[0];

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Helper function for notifying of property changes
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Side()
        {
            size = Size.Small;
        }
    }
}

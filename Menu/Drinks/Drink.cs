/*  Drink.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, INotifyPropertyChanged
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Gets the menu category of the entree
        /// </summary>
        public string Category { get; } = "Drink";

        /// <summary>
        /// Returns the string representation of this menu item
        /// </summary>
        /// <returns>String representation of menu item</returns>
        public abstract override string ToString();

        /// <summary>
        /// Gets the description of the drink
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Gets the list of special properties
        /// </summary>
        public virtual string[] Special { get; }

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

        public Drink()
        {
            size = Size.Small;
        }
    }
}
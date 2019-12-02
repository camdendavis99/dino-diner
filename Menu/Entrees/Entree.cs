/*  Entree.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, INotifyPropertyChanged
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
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets the menu category of the entree
        /// </summary>
        public string Category { get; } = "Entree";

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
    }
}

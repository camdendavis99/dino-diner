/*  IMenuItem.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem : IOrderItem
    {
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        List<string> Ingredients { get; }

        /// <summary>
        /// Gets the menu category of the item
        /// </summary>
        string Category { get; }
    }
}

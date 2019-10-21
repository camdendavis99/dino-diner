using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// String description of the item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Array holding special properties of the order item
        /// </summary>
        string[] Special { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
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

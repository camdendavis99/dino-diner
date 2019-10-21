using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a customer's order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Stores all the items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Gets the pre-tax cost of all items in the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach (IOrderItem item in Items)
                {
                    cost += item.Price;
                }
                return cost;
            }
        }

        /// <summary>
        /// Tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.09;

        /// <summary>
        /// Gets the total cost of tax for the order
        /// </summary>
        public double SalesTaxCost => SalesTaxRate * SubtotalCost;

        /// <summary>
        /// Gets the cost of the order with tax
        /// </summary>
        public double TotalCost => SubtotalCost + SalesTaxCost;
    }
}

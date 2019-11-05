/*  Order.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a DinoDiner order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        // Backing variable
        double saleTaxRate = 0;
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Event handler for when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores all the items in the order
        /// </summary>
        public IOrderItem[] Items
        {
            get => items.ToArray();
        }
 
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
        public double SalesTaxRate
        {
            get => saleTaxRate;
            set
            {
                if (value < 0) return;
                saleTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// Gets the total cost of tax for the order
        /// </summary>
        public double SalesTaxCost => SalesTaxRate * SubtotalCost;

        /// <summary>
        /// Gets the cost of the order with tax
        /// </summary>
        public double TotalCost => SubtotalCost + SalesTaxCost;

        /// <summary>
        /// Constructor - Creates a new Order object
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyOfPropertyChanged();
        }

        public bool Remove(IOrderItem item)
        {
            bool flag = items.Remove(item);
            if (flag)
            {
                NotifyOfPropertyChanged();
            }
            return flag;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged();
        }

        private void NotifyOfPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}

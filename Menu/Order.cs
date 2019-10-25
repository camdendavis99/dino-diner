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

        /// <summary>
        /// Event handler for when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores all the items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; } = new ObservableCollection<IOrderItem>();

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

        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.Add(new SteakosaurusBurger());
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}

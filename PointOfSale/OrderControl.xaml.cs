using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// NavigationService for order UI
        /// </summary>
        public static NavigationService NavigationService { get; set; }

        /// <summary>
        /// Constructor - Creates a new OrderControl
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for changing selected item in order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {

                NavigationService?.Navigate(new SideSelection(side));
            }
        }

        /// <summary>
        /// Event handler for removing item from order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (sender is FrameworkElement element)
                    if (OrderItems.SelectedItem is IOrderItem item)
                        order.Items.Remove(item);
        }
    }
}

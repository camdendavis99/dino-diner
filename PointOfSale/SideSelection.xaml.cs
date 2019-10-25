/*  SideSelection.xaml.cs
*   Author: Camden Davis
*/

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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Stores the selected side
        /// </summary>
        public Side Side { get; private set; }

        /// <summary>
        /// Stores the selected size
        /// </summary>
        public DinoDiner.Menu.Size Size { get; private set; } = DinoDiner.Menu.Size.Small;

        /// <summary>
        /// Default Constructor - Creates a new side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overflow Constructor - Creates a new side selection page 
        /// with a given selected side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        /// <summary>
        /// Adds the given side to the order
        /// </summary>
        /// <param name="side">side to be added</param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                side.Size = Size;
                order.Items.Add(side);
                Side = side;
            }
        }

        /// <summary>
        /// Changes the selected size, and size of side if a 
        /// side is selected.
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                Side.Size = size;
            }
            Size = size;
        }

        /// <summary>
        /// Sets the size to small and updates button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            MakeSmall.Background = Brushes.LightBlue;
            MakeMedium.Background = Brushes.LightGray;
            MakeLarge.Background = Brushes.LightGray;
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Sets the size to medium and updates button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            MakeSmall.Background = Brushes.LightGray;
            MakeMedium.Background = Brushes.LightBlue;
            MakeLarge.Background = Brushes.LightGray;
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Sets the size to large and updates button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            MakeSmall.Background = Brushes.LightGray;
            MakeMedium.Background = Brushes.LightGray;
            MakeLarge.Background = Brushes.LightBlue;
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Event handler for Fryceritops button;
        /// Adds a Fryceritops to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// Event handler for MeteorMacAndCheese button;
        /// Adds a MeteorMacAndCheese to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Event handler for MezzorellaSticks button;
        /// Adds a MezzorellaSticks to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Event handler for Triceritots button;
        /// Adds a Triceritots to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }
    }
}

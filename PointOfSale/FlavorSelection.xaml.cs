/*  FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda { get; set; }

        /// <summary>
        /// Default Constructor - Creates a new FlavorSelection Page
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overflow Constructor - Creates a new FlavorSelection Page
        /// for a given Sodasaurus drink
        /// </summary>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        /// <summary>
        /// Adds a sodasaurus with given flavor to the order
        /// </summary>
        /// <param name="flavor">flavor of sodasaurus</param>
        private void PickFlavor(SodasaurusFlavor flavor)
        {
            soda.Flavor = flavor;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Event handler for Cherry button
        /// </summary>
        private void OnPickCherry(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.Cherry);
        }

        /// <summary>
        /// Event handler for Chocolate button
        /// </summary>
        private void OnPickChocolate(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.Chocolate);
        }

        /// <summary>
        /// Event handler for Cola button
        /// </summary>
        private void OnPickCola(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.Cola);
        }

        /// <summary>
        /// Event handler for Lime button
        /// </summary>
        private void OnPickLime(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.Lime);
        }

        /// <summary>
        /// Event handler for Orange button
        /// </summary>
        private void OnPickOrange(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.Orange);
        }

        /// <summary>
        /// Event handler for Root Beer button
        /// </summary>
        private void OnPickRootBeer(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.RootBeer);
        }

        /// <summary>
        /// Event handler for Vanilla button
        /// </summary>
        private void OnPickVanilla(object sender, RoutedEventArgs args)
        {
            PickFlavor(SodasaurusFlavor.Vanilla);
        }
    }
}

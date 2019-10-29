/*  CustomizeCombo.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        // Text in combo buttons
        public string Entree { get; set; } = "Select Entree";
        private string Side { get; set; } = "Select Side";
        private string Drink { get; set; } = "Select Drink";

        /// <summary>
        /// Constructor - Creates a new CustomizeCombo page
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Select Entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Event handler for Select Side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Event handler for Select Drink button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Sets the selected entree
        /// </summary>
        /// <param name="entree">Selected entree</param>
        public void EntreeSelected(string entree)
        {
            Entree = entree;
        }

        /// <summary>
        /// Sets the selected side
        /// </summary>
        /// <param name="side">Selected side</param>
        public void SideSelected(string side)
        {
            Side = side;
        }

        /// <summary>
        /// Sets the selected drink
        /// </summary>
        /// <param name="drink">Selected drink</param>
        public void DrinkSelected(string drink)
        {
            Drink = drink;
        }
    }
}

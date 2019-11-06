/*  ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructor - Creates a new ComboSelection page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for selecting an entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void EntreeSelected(object sender, RoutedEventArgs args)
        {
            Button button = (Button)sender;
            string entreeText = (string)button.Tag;
            Entree entree;

            switch (entreeText)
            {
                case "Brontowurst Combo":
                    entree = new Brontowurst();
                    break;
                case "Dino-Nuggets Combo":
                    entree = new DinoNuggets();
                    break;
                case "Steakosaurus Burger Combo":
                    entree = new SteakosaurusBurger();
                    break;
                case "T-Rex King Burger Combo":
                    entree = new TRexKingBurger();
                    break;
                case "Pterodactyl Wings Combo":
                    entree = new PterodactylWings();
                    break;
                case "Prehistoric PB&J Combo":
                    entree = new PrehistoricPBJ();
                    break;
                default:
                    entree = new VelociWrap();
                    break;
            }
            CustomizeCombo comboScreen = new CustomizeCombo(entree);
            NavigationService.Navigate(comboScreen);
        }
    }
}

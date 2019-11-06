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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;

        /// <summary>
        /// Default Constructor - Creates a new CustomizeCombo page
        /// </summary>
        public CustomizeCombo(Entree entree)
        {
            InitializeComponent();
            combo = new CretaceousCombo(entree);
            if (DataContext is Order order)
            {
                order.Add(combo.Entree);
                order.Add(combo.Side);
                order.Add(combo.Drink);
            }
        }

        /// <summary>
        /// Overflow Constructor - Creates a new CustomizeCombo page
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (DataContext is Order order)
            {
                order.Add(combo.Entree);
                order.Add(combo.Side);
                order.Add(combo.Drink);
            }
        }

        /// <summary>
        /// Event handler for Done button; Adds combo to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for Select Entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectEntree(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst bw)
                NavigationService.Navigate(new CustomizeBrontowurst(bw));
            else if (combo.Entree is DinoNuggets dn)
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            else if (combo.Entree is PrehistoricPBJ pbj)
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            else if (combo.Entree is SteakosaurusBurger sb)
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            else if (combo.Entree is TRexKingBurger tb)
                NavigationService.Navigate(new CustomizeTRexKingBurger(tb));
            else if (combo.Entree is VelociWrap wrap)
                NavigationService.Navigate(new CustomizeVelociWrap(wrap));
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
    }
}

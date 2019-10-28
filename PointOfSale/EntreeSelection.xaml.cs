/*  EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Stores the selected entree
        /// </summary>
        public Entree Entree { get; private set; }

        /// <summary>
        /// Default Constructor - Creates a new entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overflow Constructor - Creates a new entree selection page 
        /// with a given selected entree
        /// </summary>
        /// <param name="side"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Adds the given entree to the order
        /// </summary>
        /// <param name="entree">entree to be added</param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
            }
        }

        // AddBrontowurst AddDinoNuggets AddSteakosaurusBurger AddTRexKingBurger AddPterodactylWings AddPrehistoricPBJ AddVelociwrap

        /// <summary>
        /// Event handler for Brontowurst button;
        /// Adds a Brontowurst to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
        }

        /// <summary>
        /// Event handler for DinoNuggets button;
        /// Adds a DinoNuggets to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        /// <summary>
        /// Event handler for SteakosaurusBurger button;
        /// Adds a SteakosaurusBurger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        /// <summary>
        /// Event handler for TRexKingBurger button;
        /// Adds a TRexKingBurger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
        }

        /// <summary>
        /// Event handler for PterodactylWings button;
        /// Adds a PterodactylWings to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Event handler for PrehistoricPBJ button;
        /// Adds a PrehistoricPBJ to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
        }

        /// <summary>
        /// Event handler for VelociWrap button;
        /// Adds a VelociWrap to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }
    }
}

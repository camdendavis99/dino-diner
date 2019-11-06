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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        // Backing variables
        private SteakosaurusBurger sb;
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Constructor - Creates a new CustomizeSteakosaurusBurger page
        /// </summary>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// Event handler for HoldBun button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (bun)
            {
                HoldBun.Background = Brushes.AliceBlue;
                bun = false;
            }
            else
            {
                HoldBun.Background = Brushes.LightGray;
                bun = true;
            }
        }

        /// <summary>
        /// Event handler for HoldPickle button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            if (pickle)
            {
                HoldPickle.Background = Brushes.AliceBlue;
                pickle = false;
            }
            else
            {
                HoldPickle.Background = Brushes.LightGray;
                pickle = true;
            }
        }

        /// <summary>
        /// Event handler for HoldKetchup button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (ketchup)
            {
                HoldKetchup.Background = Brushes.AliceBlue;
                ketchup = false;
            }
            else
            {
                HoldKetchup.Background = Brushes.LightGray;
                ketchup = true;
            }
        }

        /// <summary>
        /// Event handler for HoldMustard button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            if (mustard)
            {
                HoldMustard.Background = Brushes.AliceBlue;
                mustard = false;
            }
            else
            {
                HoldMustard.Background = Brushes.LightGray;
                mustard = true;
            }
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            if (!bun) sb.HoldBun();
            if (!pickle) sb.HoldPickle();
            if (!ketchup) sb.HoldKetchup();
            if (!mustard) sb.HoldMustard();
            NavigationService.GoBack();
        }
    }
}

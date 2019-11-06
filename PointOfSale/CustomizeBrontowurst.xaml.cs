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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        // Backing variables
        private Brontowurst bw;
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Constructor - Creates a new CustomizeBrontowurst page
        /// </summary>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        /// <summary>
        /// Event handler for HoldBun button; removes bun
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
        /// Event handler for HoldPeppers button; removes peppers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            if (peppers)
            {
                HoldPeppers.Background = Brushes.AliceBlue;
                peppers = false;
            }
            else
            {
                HoldPeppers.Background = Brushes.LightGray;
                peppers = true;
            }
        }

        /// <summary>
        /// Event handler for HoldOnion button; removes onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            if (onion)
            {
                HoldOnion.Background = Brushes.AliceBlue;
                onion = false;
            }
            else
            {
                HoldOnion.Background = Brushes.LightGray;
                onion = true;
            }
        }

        /// <summary>
        /// Event handler for Done button; 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            if (!bun) bw.HoldBun();
            if (!peppers) bw.HoldPeppers();
            if (!onion) bw.HoldOnion();
            NavigationService.GoBack();
        }
    }
}

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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {

        // Backing variables
        private TRexKingBurger tb;
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private uint pattieCount;

        /// <summary>
        /// Constructor - Creates a new CustomizeTRexKingBurger page
        /// </summary>
        public CustomizeTRexKingBurger(TRexKingBurger tb)
        {
            InitializeComponent();
            this.tb = tb;
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
        /// Event handler for HoldLettuce button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (lettuce)
            {
                HoldLettuce.Background = Brushes.AliceBlue;
                lettuce = false;
            }
            else
            {
                HoldLettuce.Background = Brushes.LightGray;
                lettuce = true;
            }
        }

        /// <summary>
        /// Event handler for HoldTomato button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            if (tomato)
            {
                HoldTomato.Background = Brushes.AliceBlue;
                tomato = false;
            }
            else
            {
                HoldTomato.Background = Brushes.LightGray;
                tomato = true;
            }
        }

        /// <summary>
        /// Event handler for HoldOnion button
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
        /// Event handler for AddPattie button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddPattie(object sender, RoutedEventArgs args)
        {
            
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            if (!bun) tb.HoldBun();
            if (!lettuce) tb.HoldLettuce();
            if (!tomato) tb.HoldTomato();
            if (!onion) tb.HoldOnion();
            if (!pickle) tb.HoldPickle();
            if (!ketchup) tb.HoldKetchup();
            if (!mustard) tb.HoldMustard();
            NavigationService.GoBack();
        }
    }
}

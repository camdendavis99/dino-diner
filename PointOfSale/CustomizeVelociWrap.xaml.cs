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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        // Backing variables
        private VelociWrap wrap;
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// Constructor - Creates a new CustomizePrehistoricPBJ page
        /// </summary>
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// Event handler for HoldDressing button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            if (dressing)
            {
                HoldDressing.Background = Brushes.AliceBlue;
                dressing = false;
            }
            else
            {
                HoldDressing.Background = Brushes.LightGray;
                dressing = true;
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
        /// Event handler for HoldCheese button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            if (cheese)
            {
                HoldCheese.Background = Brushes.AliceBlue;
                cheese = false;
            }
            else
            {
                HoldCheese.Background = Brushes.LightGray;
                cheese = true;
            }
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            if (!dressing) wrap.HoldDressing();
            if (!lettuce) wrap.HoldLettuce();
            if (!cheese) wrap.HoldCheese();
            NavigationService.GoBack();
        }
    }
}

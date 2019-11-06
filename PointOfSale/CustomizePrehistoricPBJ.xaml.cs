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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        // Backing variables
        private PrehistoricPBJ pbj;
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Constructor - Creates a new CustomizePrehistoricPBJ page
        /// </summary>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Event handler for HoldPeanutButter button; removes peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (peanutButter)
            {
                HoldPeanutButter.Background = Brushes.AliceBlue;
                peanutButter = false;
            }
            else
            {
                HoldPeanutButter.Background = Brushes.LightGray;
                peanutButter = true;
            }
        }

        /// <summary>
        /// Event handler for HoldJelly button; removes jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            if (jelly)
            {
                HoldJelly.Background = Brushes.AliceBlue;
                jelly = false;
            }
            else
            {
                HoldJelly.Background = Brushes.LightGray;
                jelly = true;
            }
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            if (!peanutButter) pbj.HoldPeanutButter();
            if (!jelly) pbj.HoldJelly();
            NavigationService.GoBack();
        }
    }
}

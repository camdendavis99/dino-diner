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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        // Backing variables
        private DinoNuggets nuggets;
        public int NuggetCount { get; private set; } = 6;

        /// <summary>
        /// Constructor - Creates a new CustomizeDinoNuggets page
        /// </summary>
        /// <param name="nuggets"></param>
        public CustomizeDinoNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nuggets = nuggets;
        }

        /// <summary>
        /// Event handler for AddNugget button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddNugget(object sender, RoutedEventArgs args)
        {
            NuggetCount++;
        }

        /// <summary>
        /// Event handler for RemoveNugget button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRemoveNugget(object sender, RoutedEventArgs args)
        {
            if (NuggetCount > 6)
                NuggetCount--;
        }

        /// <summary>
        /// Event handler for Done button; 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDone(object sender, RoutedEventArgs args)
        {
            for (int i = 6; i < NuggetCount; i++)
            {
                nuggets.AddNugget();
            }
            NavigationService.GoBack();
        }
    }
}

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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        protected Side Side { get; set; }

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                Side.Size = size;
            }
        }

        private void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            MakeSmall.Background = Brushes.LightBlue;
            MakeMedium.Background = Brushes.LightGray;
            MakeLarge.Background = Brushes.LightGray;
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        private void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            MakeSmall.Background = Brushes.LightGray;
            MakeMedium.Background = Brushes.LightBlue;
            MakeLarge.Background = Brushes.LightGray;
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        private void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            MakeSmall.Background = Brushes.LightGray;
            MakeMedium.Background = Brushes.LightGray;
            MakeLarge.Background = Brushes.LightBlue;
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        public void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        public void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        public void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        public void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            
            /*
            OrderControl order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            */
        }

        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {

        }

        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {

        }

        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            
        }
    }
}

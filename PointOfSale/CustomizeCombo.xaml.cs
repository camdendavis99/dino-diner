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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public string Entree { get; set; } = "Select Entree";
        private string Side { get; set; } = "Select Side";
        private string Drink { get; set; } = "Select Drink";

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        public void EntreeSelected(string entree)
        {
            Entree = entree;
        }

        public void SideSelected(string side)
        {
            Side = side;
        }

        public void DrinkSelected(string drink)
        {
            Drink = drink;
        }
    }
}

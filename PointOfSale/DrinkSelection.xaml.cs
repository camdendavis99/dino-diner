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
using System.Collections;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public void OnClickDone(object sender, RoutedEventArgs args)
        {
            if (Drink != null)
            {
                Drink.Ice = OptionSelected("Ice");
            }
            if (Drink is Sodasaurus soda)
            {
                AddDrink(soda);
            }
            else if (Drink is Tyrannotea tea)
            {
                tea.Sweet = OptionSelected("Sweet");
                tea.Lemon = OptionSelected("Lemon");
                AddDrink(tea);
            }
            else if (Drink is JurassicJava java)
            {
                java.RoomForCream = OptionSelected("Cream");
                java.Decaf = OptionSelected("Decaf");
                AddDrink(java);
            }
            else if (Drink is Water water)
            {
                water.Lemon = OptionSelected("Lemon");
                AddDrink(water);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void AddDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
            }
        }

        /// <summary>
        /// Navigates the UI to the FlavorSelection page for a SodaSaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFlavor()
        {
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }

        private void RemoveOptions()
        {
            Options.Children.Clear();
            CheckBox ice = new CheckBox();
            ice.Name = "Ice";
            ice.IsChecked = true;
        }

        private bool OptionSelected(String optionName)
        {
            return (bool)((CheckBox)FindName(optionName)).IsChecked;
        }

        /// <summary>
        /// Event handler for Sodasaurus button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            RemoveOptions();
            Drink = new Sodasaurus();
            SelectFlavor();
        }

        /// <summary>
        /// Event handler for Tyrannotea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            RemoveOptions();
            Drink = new Tyrannotea();
        }

        /// <summary>
        /// Event handler for Jurassic Java button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            RemoveOptions();
            Drink = new JurassicJava();
        }

        /// <summary>
        /// Event handler for Water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            RemoveOptions();
            Drink = new Water();
        }
    }
}

/*  DrinkSelection.xaml.cs
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
using System.Collections;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Gets or sets the current drink
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Default Constructor - Creates a new DrinkSelection Page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overflow Constructor - Creates a new DrinkSelection Page
        /// with given drink
        /// </summary>
        /// <param name="drink">Selected drink</param>
        public DrinkSelection(Drink drink)
        {
            Drink = drink;
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Done button; Adds drink with custom
        /// options to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// Adds drink to order
        /// </summary>
        /// <param name="drink">drink to add</param>
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

        /// <summary>
        /// Clears the list of options, but keeps Ice as an option
        /// </summary>
        private void RemoveOptions()
        {
            Options.Children.Clear();
            CheckBox ice = new CheckBox();
            ice.Name = "Ice";
            ice.Content = "Ice";
            ice.IsChecked = true;
            Options.Children.Add(ice);
        }

        /// <summary>
        /// Checks if the option with the given name is selected
        /// </summary>
        /// <param name="optionName">Name of option to check</param>
        /// <returns>Whether or not the option was selected</returns>
        private bool OptionSelected(string optionName)
        {
            CheckBox option = (CheckBox)FindName(optionName);
            if (option != null)
                return (bool)(option).IsChecked;
            return false;
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
            CheckBox sweet = new CheckBox();
            CheckBox lemon = new CheckBox();

            sweet.Name = "Sweet";
            lemon.Name = "Lemon";
            sweet.Content = "Sweet";
            lemon.Content = "Lemon";
            Options.Children.Add(sweet);
            Options.Children.Add(lemon);

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
            CheckBox cream = new CheckBox();
            CheckBox decaf = new CheckBox();

            cream.Name = "Cream";
            decaf.Name = "Decaf";
            cream.Content = "Cream";
            decaf.Content = "Decaf";
            Options.Children.Add(cream);
            Options.Children.Add(decaf);

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
            CheckBox lemon = new CheckBox();
            
            lemon.Name = "Lemon";
            lemon.Content = "Lemon";
            Options.Children.Add(lemon);

            CheckBox ice = (CheckBox)FindName("Ice");
            ice.IsChecked = false;

            Drink = new Water();
        }
    }
}

/*  CretaceousCombo.cs
*   Author: Camden Davis
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the size
        /// </summary>
        private Size size;
        
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Event handler for any property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Helper function for notifying of property changes
        protected void NotifyOfPropertyChange()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        
        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
        }

        /// <summary>
        /// Gets the menu category of the combo
        /// </summary>
        public string Category { get; } = "Combo";

        /// <summary>
        /// Returns a string representation of the combo
        /// </summary>
        /// <returns>The string representation of the combo</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        public string Description => ToString();

        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();

            }
        }
    }
}

/*  Menu.cshtml.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Stores the menu items with the filters applied
        /// </summary>
        public List<IMenuItem> FilteredMenu = MenuDatabase.All;

        /// <summary>
        /// Instance of Menu class
        /// </summary>
        public Menu Menu = new Menu();

        /// <summary>
        /// Search query
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// Menu categories to be displayed
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// Minimum price of menu items to display
        /// </summary>
        [BindProperty]
        public float? minPrice { get; set; }

        /// <summary>
        /// Maximum price of menu items to display
        /// </summary>
        [BindProperty]
        public float? maxPrice { get; set; }

        /// <summary>
        /// List of ingredients in menu items to exclude
        /// </summary>
        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

        /// <summary>
        /// Gets the combos from the filtered menu items
        /// </summary>
        public List<CretaceousCombo> FilteredCombos
        {
            get
            {
                List<CretaceousCombo> result = new List<CretaceousCombo>();
                foreach (IMenuItem item in FilteredMenu)
                {
                    if (item.Category.Equals("Combo"))
                        result.Add((CretaceousCombo)item);
                }
                return result;
            }
        }

        /// <summary>
        /// Gets the entrees from the filtered menu items
        /// </summary>
        public List<Entree> FilteredEntrees
        {
            get
            {
                List<Entree> result = new List<Entree>();
                foreach (IMenuItem item in FilteredMenu)
                {
                    if (item.Category.Equals("Entree"))
                        result.Add((Entree)item);
                }
                return result;
            }
        }

        /// <summary>
        /// Gets the sides from the filtered menu items
        /// </summary>
        public List<Side> FilteredSides
        {
            get
            {
                List<Side> result = new List<Side>();
                foreach (IMenuItem item in FilteredMenu)
                {
                    if (item.Category.Equals("Side"))
                        result.Add((Side)item);
                }
                return result;
            }
        }

        /// <summary>
        /// Gets the drinks from the filtered menu items
        /// </summary>
        public List<Drink> FilteredDrinks
        {
            get
            {
                List<Drink> result = new List<Drink>();
                foreach (IMenuItem item in FilteredMenu)
                {
                    if (item.Category.Equals("Drink"))
                        result.Add((Drink)item);
                }
                return result;
            }
        }

        /// <summary>
        /// Handles creation of the Menu page
        /// </summary>
        public void OnGet()
        {
            FilteredMenu = MenuDatabase.All;
        }

        /// <summary>
        /// Handles when the search and filter button is pressed
        /// </summary>
        /// <param name="search"></param>
        /// <param name="menuCategory"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="excludeIngredient"></param>
        public void OnPost(string search, List<string> menuCategory, float? minPrice, float? maxPrice, List<string> excludeIngredient)
        {
            FilteredMenu = MenuDatabase.All;
            if (search != null)
            {
                FilteredMenu = MenuDatabase.Search(FilteredMenu, search);
            }
            if (menuCategory.Count > 0)
            {
                FilteredMenu = MenuDatabase.FilterByMenuCategory(FilteredMenu, menuCategory);
            }
            if (minPrice != null)
            {
                FilteredMenu = MenuDatabase.FilterByMinPrice(FilteredMenu, (float)minPrice);
            }
            if (maxPrice != null)
            {
                FilteredMenu = MenuDatabase.FilterByMaxPrice(FilteredMenu, (float)maxPrice);
            }
            if (excludeIngredient.Count > 0)
            {
                FilteredMenu = MenuDatabase.FilterByIngredients(FilteredMenu, excludeIngredient);
            }
        }
    }
}
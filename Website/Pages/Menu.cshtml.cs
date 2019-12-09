/*  Menu.cshtml.cs
*   Author: Camden Davis
*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Instance of Menu class
        /// </summary>
        public Menu Menu = new Menu();

        /// <summary>
        /// Stores the menu items with the filters applied
        /// </summary>
        public IEnumerable<IMenuItem> FilteredMenu;// = Menu.AvailableMenuItems;

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
        public IEnumerable<IMenuItem> FilteredCombos => FilteredMenu.Where(item => item.Category.Equals("Combo"));

        /// <summary>
        /// Gets the entrees from the filtered menu items
        /// </summary>
        public IEnumerable<IMenuItem> FilteredEntrees => FilteredMenu.Where(item => item.Category.Equals("Entree"));

        /// <summary>
        /// Gets the sides from the filtered menu items
        /// </summary>
        public IEnumerable<IMenuItem> FilteredSides => FilteredMenu.Where(item => item.Category.Equals("Side"));

        /// <summary>
        /// Gets the drinks from the filtered menu items
        /// </summary>
        public IEnumerable<IMenuItem> FilteredDrinks => FilteredMenu.Where(item => item.Category.Equals("Drink"));

        /// <summary>
        /// Handles creation of the Menu page
        /// </summary>
        public void OnGet()
        {
            FilteredMenu = Menu.AvailableMenuItems;
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
            FilteredMenu = Menu.AvailableMenuItems;
            if (search != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Description != null && item.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (menuCategory.Count > 0)
            {
                FilteredMenu = FilteredMenu.Where(item => menuCategory.Contains(item.Category));
            }
            if (minPrice != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Price >= (float)minPrice);
            }
            if (maxPrice != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Price >= (float)maxPrice);
            }
            foreach (string ingredient in excludeIngredient)
            {
                FilteredMenu = FilteredMenu.Where(item => !item.Ingredients.Contains(ingredient));
            }
        }
    }
}
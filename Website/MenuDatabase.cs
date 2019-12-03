/*  MenuDatabase.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;

namespace Website
{
    public class MenuDatabase
    {
        private static Menu menu = new Menu();

        /// <summary>
        /// Gets all menu items
        /// </summary>
        public static List<IMenuItem> All
        {
            get => menu.AvailableMenuItems;
        }

        /// <summary>
        /// Applies a search query to the given list of menu items
        /// </summary>
        /// <param name="filteredMenu"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> filteredMenu, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in filteredMenu)
            {
                if (item.Description != null && item.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                    results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters a given list by menu category
        /// </summary>
        /// <param name="filteredMenu"></param>
        /// <param name="menuCategory"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMenuCategory(List<IMenuItem> filteredMenu, List<string> menuCategory)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in filteredMenu)
            {
                if (menuCategory.Contains(item.Category))
                    results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters a given list by minimum price
        /// </summary>
        /// <param name="filteredMenu"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> filteredMenu, float price)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in filteredMenu)
            {
                if (item.Price >= price)
                    results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters a given list by maximum price
        /// </summary>
        /// <param name="filteredMenu"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> filteredMenu, float price)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in filteredMenu)
            {
                if (item.Price <= price)
                    results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters a given list by excluding items with given ingredients
        /// </summary>
        /// <param name="filteredMenu"></param>
        /// <param name="excludeIngredients"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> filteredMenu, List<string> excludeIngredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in filteredMenu)
            {
                bool hasExcludedIngredient = false;
                foreach (string ingredient in item.Ingredients)
                {
                    if (excludeIngredients.Contains(ingredient))
                    {
                        hasExcludedIngredient = true;
                        break;
                    }
                }
                if (!hasExcludedIngredient)
                    results.Add(item);
            }

            return results;
        }
    }
}

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
        public List<IMenuItem> FilteredMenu = MenuDatabase.All;
        public Menu Menu = new Menu();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

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

        public void OnGet()
        {
            FilteredMenu = MenuDatabase.All;
        }

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
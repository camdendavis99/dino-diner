using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public Menu Menu = new Menu();
        public List<IMenuItem> FilteredMenu;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        public void OnGet()
        {
            FilteredMenu = Menu.AvailableMenuItems;
        }

        public void OnPost(string search, List<string> menuCategory, float? minPrice, float? maxPrice, List<string> excludeIngredients)
        {
            FilteredMenu = Menu.AvailableMenuItems;
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
            if (excludeIngredients.Count > 0)
            {
                FilteredMenu = MenuDatabase.FilterByIngredients(FilteredMenu, excludeIngredients);
            }
        }
    }
}

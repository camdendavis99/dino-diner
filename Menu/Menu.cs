/*  Menu.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Gets the list of all possible ingredients
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                HashSet<string> all = new HashSet<string>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        if (!all.Contains(ingredient))
                            all.Add(ingredient);
                    }
                }
                return all.ToList();
            }
        }

        /// <summary>
        /// Gets the list of all available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots(),
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        /// <summary>
        /// Gets the list of all available Combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                return new List<CretaceousCombo>()
                {
                    new BrontowurstCombo(),
                    new DinoNuggetsCombo(),
                    new PrehistoricPBJCombo(),
                    new PterodactylWingsCombo(),
                    new SteakosaurusBurgerCombo(),
                    new TRexKingBurgerCombo(),
                    new VelociWrapCombo()
                };
            }
        }

        /// <summary>
        /// Gets the list of all available entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                return new List<Entree>()
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
            }
        }

        /// <summary>
        /// Gets the list of all available sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                return new List<Side>()
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }

        /// <summary>
        /// Gets the list of all available drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                return new List<Drink>()
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }
    }
}

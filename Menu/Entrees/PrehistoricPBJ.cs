using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Whether or not the PBJ will have peanut butter
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Whether or not the PBJ will have jelly
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Gets the list of ingredients base on which have been chosen
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new PrehistoricPBJ with default Price and Calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Removes jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}

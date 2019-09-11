﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Flour Tortilla",
                    "Chicken Breast"
                };
                if (dressing) ingredients.Add("Caesar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return Ingredients;
            }
        }

        public void HoldDressing()
        {
            dressing = false;
        }

        public void HoldLettuce()
        {
            lettuce = false;
        }

        public void HoldCheese()
        {
            cheese = false;
        }
    }
}

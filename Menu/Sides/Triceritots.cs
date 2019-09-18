using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public override Size Size
        {
            get => Size;
            set
            {
                switch (value)
                {
                    case Size.Small:
                        Size = Size.Small;
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Size = Size.Medium;
                        Price = 1.45;
                        Calories = 410;
                        break;
                    default:
                        Size = Size.Large;
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>()
                {
                    "Potato",
                    "Salt",
                    "Vegetable Oil"
                };
            }
        }

        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
            this.Size = Size.Small;
        }
    }
}

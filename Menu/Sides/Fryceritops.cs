using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Size = Size.Medium;
                        Price = 1.45;
                        Calories = 365;
                        break;
                    default:
                        Size = Size.Large;
                        Price = 1.95;
                        Calories = 480;
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

        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Size = Size.Small;
        }
    }
}

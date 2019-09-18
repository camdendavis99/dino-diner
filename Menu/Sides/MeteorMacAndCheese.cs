using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Size = Size.Medium;
                        Price = 1.45;
                        Calories = 490;
                        break;
                    default:
                        Size = Size.Large;
                        Price = 1.95;
                        Calories = 520;
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
                    "Macaroni Noodles",
                    "Cheese Product",
                    "Pork Sausage"
                };
            }
        }

        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Size = Size.Small;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Size = Size.Medium;
                        Price = 1.45;
                        Calories = 610;
                        break;
                    default:
                        Size = Size.Large;
                        Price = 1.95;
                        Calories = 720;
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
                    "Breading",
                    "Cheese Product",
                    "Vegetable Oil"
                };
            }
        }

        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Size = Size.Small;
        }
    }
}

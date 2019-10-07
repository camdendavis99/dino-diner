/*  SteakosaurusBurgerCombo.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurgerCombo : CretaceousCombo
    {
        /// <summary>
        /// Creates a new SteakosaurusBurgerCombo
        /// </summary>
        public SteakosaurusBurgerCombo() : base(new SteakosaurusBurger()) { }
    }
}
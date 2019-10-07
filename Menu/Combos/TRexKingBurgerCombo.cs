/*  TRexKingBurgerCombo.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurgerCombo : CretaceousCombo
    {
        /// <summary>
        /// Creates a new TRexKingBurgerCombo
        /// </summary>
        public TRexKingBurgerCombo() : base(new TRexKingBurger()) { }
    }
}
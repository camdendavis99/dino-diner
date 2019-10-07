/*  DinoNuggetsCombo.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggetsCombo : CretaceousCombo
    {
        /// <summary>
        /// Creates a new DinoNuggetsCombo
        /// </summary>
        public DinoNuggetsCombo() : base(new DinoNuggets()) { }
    }
}

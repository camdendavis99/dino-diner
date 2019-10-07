/*  PterodactylWingsCombo.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PterodactylWingsCombo : CretaceousCombo
    {
        /// <summary>
        /// Creates a new PterodactylWingsCombo
        /// </summary>
        public PterodactylWingsCombo() : base(new PterodactylWings()) { }
    }
}
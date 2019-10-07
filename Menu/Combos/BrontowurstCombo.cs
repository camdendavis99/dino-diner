/*  BrontowurstCombo.cs
*   Author: Camden Davis
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class BrontowurstCombo : CretaceousCombo
    {
        /// <summary>
        /// Creates a new BrontowurstCombo
        /// </summary>
        public BrontowurstCombo() : base(new Brontowurst()) { }
    }
}

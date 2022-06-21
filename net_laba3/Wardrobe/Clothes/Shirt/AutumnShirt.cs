using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Shirt
{
     public class AutumnShirt : IShirt
    {
        public string GetShirt()
        {
            string autumnShirt = "Blazer";

            return autumnShirt;
        }

    }
}

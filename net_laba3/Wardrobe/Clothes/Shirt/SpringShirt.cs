using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Shirt
{
    public class SpringShirt : IShirt
    {
        public string GetShirt()
        {
            string springShirt = "T-shirt";

            return springShirt;
        }
    }
}

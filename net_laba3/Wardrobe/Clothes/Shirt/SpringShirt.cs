using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace laba3.Wardrobe.Clothes.Shirts
{
    public class SpringShirt : IShirt
    {
        public string GetSpringShirt()
        {
            string springShirt = "T-shirt";

            return springShirt;
        }
    }
}

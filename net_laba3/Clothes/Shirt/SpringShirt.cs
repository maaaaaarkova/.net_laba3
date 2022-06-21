using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Shirt
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

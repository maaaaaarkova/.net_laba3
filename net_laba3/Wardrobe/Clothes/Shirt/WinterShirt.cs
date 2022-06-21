using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Shirt
{
    public class WinterShirt : IShirt
    {
        public string GetShirt()
        {
            string winterShirt = "Coat";

            return winterShirt;
        }
    }
}

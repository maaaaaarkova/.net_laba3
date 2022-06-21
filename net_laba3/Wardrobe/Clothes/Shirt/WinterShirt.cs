using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace laba3.Wardrobe.Clothes.Shirts
{
    public class WinterShirt : IShirt
    {
        public string GetWinterShirt()
        {
            string winterShirt = "Coat";

            return winterShirt;
        }
    }
}

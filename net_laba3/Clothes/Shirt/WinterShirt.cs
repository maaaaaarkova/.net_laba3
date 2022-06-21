using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Shirt
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

using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Pants
{
    public class WinterPants : IPants
    {
        public string GetPants()
        {
            string winterPants = "Jeans";

            return winterPants;
        }
    }
}

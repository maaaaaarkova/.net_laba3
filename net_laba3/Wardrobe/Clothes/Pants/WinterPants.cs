using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace laba3.Wardrobe.Clothes.Pants
{
    public class WinterPants : IPants
    {
        public string GetWinterPants()
        {
            string winterPants = "Jeans";

            return winterPants;
        }
    }
}

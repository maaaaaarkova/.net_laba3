using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace laba3.Wardrobe.Clothes.Pants
{
    public class SummerPants : IPants
    {
        public string GetSummerPants()
        {
            string summerPants = "Jeans shorts";

            return summerPants;
        }
    }
}

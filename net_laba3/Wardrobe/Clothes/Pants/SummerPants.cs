using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Pants
{
    public class SummerPants : IPants
    {
        public string GetPants()
        {
            string summerPants = "Jeans shorts";

            return summerPants;
        }
    }
}

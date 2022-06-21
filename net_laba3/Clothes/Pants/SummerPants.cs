using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Pants
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

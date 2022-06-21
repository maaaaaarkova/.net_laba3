using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Pants
{
    public class SpringPants : IPants
    {
        public string GetPants()
        {
            string springPants = "Leggings";

            return springPants;
        }
    }
}

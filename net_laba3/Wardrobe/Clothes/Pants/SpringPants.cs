using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace laba3.Wardrobe.Clothes.Pants
{
    public class SpringPants : IPants
    {
        public string GetSpringPants()
        {
            string springPants = "Leggings";

            return springPants;
        }
    }
}

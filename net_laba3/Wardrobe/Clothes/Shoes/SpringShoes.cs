using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Shoes
{
    public class SpringShoes : IShoes
    {
        public string GetShoes()
        {
            string springShoes = "Sneakers";

            return springShoes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Shoes
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

using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Shoes
{
    public class AutumnShoes : IShoes
    {
        public string GetShoes()
        {
            string autumnShoes = "Boots";

            return autumnShoes;
        }
    }
}

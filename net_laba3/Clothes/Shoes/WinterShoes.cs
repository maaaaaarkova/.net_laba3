using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Shoes
{
    public class WinterShoes : IShoes
    {
        public string GetShoes()
        {
            string winterShoes = "Winter boots";

            return winterShoes;
        }
    }
}

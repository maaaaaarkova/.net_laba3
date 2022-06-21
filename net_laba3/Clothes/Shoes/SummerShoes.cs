using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Shoes
{
    public class SummerShoes : IShoes
    {
        public string GetShoes()
        {
            string summerShoes = "Sandals";

            return summerShoes;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Shirt
{
    public class SummerShirt : IShirt
    {
        public string GetShirt()
        {
            string summerShirt = "Top";

            return summerShirt;
        }
    }
}

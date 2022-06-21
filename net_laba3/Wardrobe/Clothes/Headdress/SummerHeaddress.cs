using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;

namespace Wardrobe.Clothes.Headdress
{
    public class SummerHeaddress : IHeaddress
    {
        public string GetHeaddress()
        {
            string summerHeaddress = "Straw hat";

            return summerHeaddress;
        }
    }
}

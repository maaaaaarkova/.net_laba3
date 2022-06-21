using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Headdress
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

using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Headdress
{
    public class WinterHeaddress : IHeaddress
    {
        public string GetHeaddress()
        {
            string winterHeaddress = "Woolly hat";

            return winterHeaddress;
        }
    }
}

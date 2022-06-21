using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Headdress
{
    public class AutumnHeaddress : IHeaddress
    {
        public string GetHeaddress()
        {
            string autumnHeaddress = "Beanie";

            return autumnHeaddress;
        }
    }
}

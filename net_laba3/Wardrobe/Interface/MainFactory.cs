using System;
using System.Collections.Generic;
using System.Text;

namespace Wardrobe.Interface
{
    public interface MainFactory
    {
        IHeaddress GetHeaddress();
        IPants GetPants();
        IShirt GetShirt();
        IShoes GetShoes();
    }
}

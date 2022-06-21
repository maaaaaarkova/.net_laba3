using System;
using System.Collections.Generic;
using System.Text;

namespace Wardrobe.Interface
{
    public interface MainFactory
    {
        IHeaddress ChooseHeaddress();
        IPants ChoosePants();
        IShirt ChooseShirt();
        IShoes ChooseShoes();
    }
}

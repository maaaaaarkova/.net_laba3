using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IFactory
    {
        IHeaddress ChooseHeaddress();
        IPants ChoosePants();
        IShirt ChooseShirt();
        IShoes ChooseShoes();
    }
}

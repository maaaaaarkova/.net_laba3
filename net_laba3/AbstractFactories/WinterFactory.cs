using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using Clothes.Pants;
using Clothes.Shirt;
using Clothes.Shoes;
using Clothes.Headdress;

namespace AbstractFactories
{
    public class WinterFactory : IFactory
    {
        public IHeaddress ChooseHeaddress()
        {
            return new WinterHeaddress();
        }

        public IPants ChoosePants()
        {
            return new WinterPants();
        }

        public IShoes ChooseShoes()
        {
            return new WinterShoes();
        }

        public IShirt ChooseShirt()
        {
            return new WinterShirt();
        }
    }
}

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
    public class SpringFactory : IFactory
    {
        public IHeaddress ChooseHeaddress()
        {
            return new SpringHeaddress();
        }

        public IPants ChoosePants()
        {
            return new SpringPants();
        }

        public IShoes ChooseShoes()
        {
            return new SpringShoes();
        }

        public IShirt ChooseShirt()
        {
            return new SpringShirt();
        }
    }
}

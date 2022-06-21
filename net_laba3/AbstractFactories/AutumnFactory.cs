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
    public class AutumnFactory : IFactory
    {
        public IHeaddress ChooseHeaddress()
        {
            return new AutumnHeaddress();
        }

        public IPants ChoosePants()
        {
            return new AutumnPants();
        }

        public IShoes ChooseShoes()
        {
            return new AutumnShoes();
        }

        public IShirt ChooseShirt()
        {
            return new AutumnShirt();
        }
    }
}

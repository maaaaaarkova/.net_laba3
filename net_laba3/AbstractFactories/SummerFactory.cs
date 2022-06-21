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
    public class SummerFactory : IFactory
    {
        public IHeaddress ChooseHeaddress()
        {
            return new SummerHeaddress();
        }

        public IPants ChoosePants()
        {
            return new SummerPants();
        }

        public IShoes ChooseShoes()
        {
            return new SummerShoes();
        }

        public IShirt ChooseShirt()
        {
            return new SummerShirt();
        }
    }
}

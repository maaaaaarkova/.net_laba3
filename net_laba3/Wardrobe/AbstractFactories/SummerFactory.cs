using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.Interface;
using Wardrobe.Clothes.Pants;
using Wardrobe.Clothes.Shirt;
using Wardrobe.Clothes.Shoes;
using Wardrobe.Clothes.Headdress;

namespace Wardrobe.AbstractFactories
{
    public class SummerFactory : MainFactory
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

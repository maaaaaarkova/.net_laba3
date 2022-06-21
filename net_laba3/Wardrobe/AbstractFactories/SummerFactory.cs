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
        public IHeaddress GetHeaddress()
        {
            return new SummerHeaddress();
        }

        public IPants GetPants()
        {
            return new SummerPants();
        }

        public IShoes GetShoes()
        {
            return new SummerShoes();
        }

        public IShirt GetShirt()
        {
            return new SummerShirt();
        }
    }
}

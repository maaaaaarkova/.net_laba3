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
    public class WinterFactory : MainFactory
    {
        public IHeaddress GetHeaddress()
        {
            return new WinterHeaddress();
        }

        public IPants GetPants()
        {
            return new WinterPants();
        }

        public IShoes GetShoes()
        {
            return new WinterShoes();
        }

        public IShirt GetShirt()
        {
            return new WinterShirt();
        }
    }
}

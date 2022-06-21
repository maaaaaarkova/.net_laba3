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

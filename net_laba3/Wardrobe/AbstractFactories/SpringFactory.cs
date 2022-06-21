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
    public class SpringFactory : MainFactory
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

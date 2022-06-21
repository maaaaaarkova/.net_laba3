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
        public IHeaddress GetHeaddress()
        {
            return new SpringHeaddress();
        }

        public IPants GetPants()
        {
            return new SpringPants();
        }

        public IShoes GetShoes()
        {
            return new SpringShoes();
        }

        public IShirt GetShirt()
        {
            return new SpringShirt();
        }
    }
}

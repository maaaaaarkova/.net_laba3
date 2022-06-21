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
    public class AutumnFactory : MainFactory
    {
        public IHeaddress GetHeaddress()
        {
            return new AutumnHeaddress();
        }

        public IPants GetPants()
        {
            return new AutumnPants();
        }

        public IShoes GetShoes()
        {
            return new AutumnShoes();
        }

        public IShirt GetShirt()
        {
            return new AutumnShirt();
        }
    }
}

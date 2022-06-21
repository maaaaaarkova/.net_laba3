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

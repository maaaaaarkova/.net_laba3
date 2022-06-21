using System;
using System.Collections.Generic;
using System.Text;
using Interface;

namespace Clothes.Pants
{
    public class AutumnPants : IPants
    {
        public string GetPants()
        {
            string autumnPants = "Trousers";

            return autumnPants;
        }
    }
}

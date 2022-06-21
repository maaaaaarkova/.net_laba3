using System;
using AbstractFactories;
using Interface;
using Clothes.Headdress;


namespace laba3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Winter outfit: ");
            IFactory winterFactory = new WinterFactory();
            var winterHeaddress = winterFactory.ChooseHeaddress();
            Console.WriteLine($"Headdress: {winterHeaddress.GetHeaddress()}");
            var winterShirt = winterFactory.ChooseShirt();
            Console.WriteLine($"Shirt: {winterShirt.GetShirt()}");
            var winterPants = winterFactory.ChoosePants();
            Console.WriteLine($"Pants: {winterPants.GetPants()}");
            var winterShoes = winterFactory.ChooseShoes();
            Console.WriteLine($"Shoes: {winterShoes.GetShoes()}");

            Console.WriteLine("\n");

            Console.WriteLine("Spring outfit: ");
            IFactory springFactory = new SpringFactory();
            var springHeaddress = springFactory.ChooseHeaddress();
            Console.WriteLine($"Headdress: {springHeaddress.GetHeaddress()}");
            var springShirt = springFactory.ChooseShirt();
            Console.WriteLine($"Shirt: {springShirt.GetShirt()}");
            var springPants = springFactory.ChoosePants();
            Console.WriteLine($"Pants: {springPants.GetPants()}");
            var springShoes = springFactory.ChooseShoes();
            Console.WriteLine($"Shoes: {springShoes.GetShoes()}");

            Console.WriteLine("\n");

            Console.WriteLine("Summer outfit: ");
            IFactory summerFactory = new SummerFactory();
            var summerHeaddress = summerFactory.ChooseHeaddress();
            Console.WriteLine($"Headdress: {summerHeaddress.GetHeaddress()}");
            var summerShirt = summerFactory.ChooseShirt();
            Console.WriteLine($"Shirt: {summerShirt.GetShirt()}");
            var summerPants = summerFactory.ChoosePants();
            Console.WriteLine($"Pants: {summerPants.GetPants()}");
            var summerShoes = summerFactory.ChooseShoes();
            Console.WriteLine($"Shoes: {summerShoes.GetShoes()}");

            Console.WriteLine("\n");

            Console.WriteLine("Autumn outfit: ");
            IFactory autumnFactory = new AutumnFactory();
            var autumnHeaddress = autumnFactory.ChooseHeaddress();
            Console.WriteLine($"Headdress: {autumnHeaddress.GetHeaddress()}");
            var autumnShirt = autumnFactory.ChooseShirt();
            Console.WriteLine($"Shirt: {autumnShirt.GetShirt()}");
            var autumnPants = autumnFactory.ChoosePants();
            Console.WriteLine($"Pants: {autumnPants.GetPants()}");
            var autumnShoes = autumnFactory.ChooseShoes();
            Console.WriteLine($"Shoes: {autumnShoes.GetShoes()}");
        }
    }
}

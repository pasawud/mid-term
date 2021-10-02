using System;
using System.Collections.Generic;

namespace Flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            string selectFlower;

            FlowerStore flowerStore = new FlowerStore();
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("---------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Select number for buy flower : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("- = - = - = - = - = - = - = - = -");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                    Console.WriteLine("You select : {0}", i);
                }
                Console.WriteLine("---------------------------------");
                Console.Write("I select number ");
                selectFlower = Console.ReadLine();
                Console.WriteLine("---------------------------------");
                switch (selectFlower)
                {
                    case "1":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added" + flowerStore.flowerList[0]);
                        break;
                    case "2":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added" + flowerStore.flowerList[0]);
                        break;
                    default:
                        Console.WriteLine("Added" + flowerStore.flowerList[0]);
                        break;
                }

                Console.WriteLine("You can stop this progress? exit for >> exit << progress and press any key for continue");
                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    Console.Write("Current my cart : ");
                    flowerStore.showCart();
                }

            }
            while (decide != "exit");

        }
        class FlowerStore
        {
            public List<string> flowerList = new List<string>(); List<string> cart = new List<string>();
            public FlowerStore()
            {
                flowerList.Add("Rose");
                flowerList.Add("Lotus");
            }
            public void addToCart(string name)
            {
                cart.Add(name);
            }
            public void showCart()
            {
                if (cart.Count == 0)
                {
                    Console.WriteLine("Cart is empty");
                }
                else
                {
                    Console.WriteLine("My Cart :"); foreach (string i in cart)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

    }
}
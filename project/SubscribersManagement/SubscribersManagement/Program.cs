using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Caching;

namespace SubscribersManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CashingSystem cache = new CashingSystem();

            while(true)
            {
                Console.WriteLine("Enter username and duration (Type q to quit): ");
                string input = Console.ReadLine();

                if (input.Equals("q")) break;

                string[] usersInfo = input.Split();
                cache.AddToCache(usersInfo[0], usersInfo[1]);
                cache.PrintCache();
            }
        }
    }
}

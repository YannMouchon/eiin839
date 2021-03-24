using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathsLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsService.MathsServiceClient client = new MathsService.MathsServiceClient();
            Console.WriteLine(client.Add(5, 6));
            Console.ReadLine();
        }
    }
}

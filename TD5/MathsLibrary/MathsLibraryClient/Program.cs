using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService.MathsOperationsClient client = new MathService.MathsOperationsClient();
            Console.WriteLine(client.Add(4, 6));
            Console.ReadLine();
            
        }
    }
}

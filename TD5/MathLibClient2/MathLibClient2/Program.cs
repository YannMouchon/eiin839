using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService.MathsOperationsClient client = new MathService.MathsOperationsClient();
            Console.WriteLine(client.Multiply(4, 5));
            Console.ReadLine();
        }
    }
}

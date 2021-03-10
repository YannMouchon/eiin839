using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSoap
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculatorSoap calc = new Calculator.CalculatorSoapClient();
            int x = calc.Add(3, 4);
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}

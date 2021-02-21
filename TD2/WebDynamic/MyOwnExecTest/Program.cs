using System;

namespace MyOwnExecTest
{
    class Program // Il s'agit juste de générer un executable qui sera ensuite appelé depuis un autre programme
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine("<HTML><BODY> " + args[0] + " et " + args[1] + " </BODY></HTML>"); 
            else
                Console.WriteLine("ExeTest <string parameter1> <string parameter2>"); // Si l'executable n'a pas exactement 2 arguments passés en paramètre, alors on montre l'usage de l'executable
            Console.ReadLine(); // fait en sorte que la console ne se referme pas immédiatement
        }
    }
}

using System;
using System.Diagnostics;

namespace CallPythonScript
{
    class Program // Le but de ce programme est d'appeler un script d'un langage interprêté et qui n'a donc pas la possibilité de générer un executable.
    {
        static void Main(string[] args)
        {
            string arguments = "Bob John";
            string fileName = @"C:\Users\yannm\Documents\SI4\SOC\eiin839\TD2\WebDynamic\CallPythonScript\externalScript.py" + " " + arguments; // je passe mes arguments à la suite du path du script
            // Ici je donne le path de mon script Python

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\\Users\\yannm\\AppData\\Local\\Programs\\Python\\Python37\\python.exe", fileName)
            // Ici je donne le path de mon interpreteur Python. Pour le trouver, j'ai executer la commande "os.path.dirname(sys.executable)" dans mon interpreteur Python 
            // C'est une étape supplémentaire lorsqu'on pas d'executable.
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd(); // je viens récupérer la sortie de mon script pour le rediriger sur la sortie standard du programme en C#
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}

using System;
using System.Diagnostics;

namespace CallPythonScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string arguments = "Bob John";
            string fileName = @"C:\Users\yannm\Documents\SI4\SOC\eiin839\TD2\CallPythonScript\externalScript.py" + " " + arguments; // je passe mes arguments à la suite du path du script
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

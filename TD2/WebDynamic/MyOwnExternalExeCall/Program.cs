using System;
using System.Diagnostics;
using System.IO;

namespace MyOwnExternalExeCall
{
    class Program // Le but de ce programme est d'utiliser un executable externe et récupérer ce qui a été écrit sur la sortie standard de l'executable pour la rediriger sur la sortie standard de notre programme
    {
        static void Main(string[] args)
        {
   
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\yannm\Documents\SI4\SOC\eiin839\TD2\WebDynamic\MyOwnExecTest\bin\Debug\netcoreapp3.1\MyOwnExecTest.exe"; // Le chemin de l'executable que l'on souhaite appeler.
            start.Arguments = "géantVert Johhhhhhhny"; // Les arguments que l'on passe à l'executable
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // On démarre le process qui appelle l'executable
            //
            using (Process process = Process.Start(start))
            {
                //
                // On récupère la sortie standard de l'executable pour la rediriger sur la sortie de notre programme
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
            }
        }
    }
}
